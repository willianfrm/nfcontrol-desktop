using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using MySql.Data.MySqlClient;

namespace Recebimento_NFS
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr_notas, dr_boletos; //USAR PARA SELECT
        //string str_conexao = "Server=localhost;Database=nfeprotocolo;Uid=root;Pwd=";
        string str_conexao; //puxando do arquivo no metoro initializecomponent logo abaixo

        Nota_Fiscal nfe;
        bool boleto = false; //SE FOR TRUE ESTÁ INSERINDO BOLETO

        string data;
        string data_atual;

        bool mover = false; //SE FOR TRUE, ESTÁ MOVENDO UMA NOTA OK DE UMA DATA PARA A DATA ATUAL
        string id_mover;

        public Form1()
        {
            InitializeComponent();

            Configurar config = new Configurar();
            str_conexao = config.StringConexao();

            atualizar_data();

            //string datetimenow = DateTime.Now.ToString("dd/MM/yyyy");
            //data = datetimenow;
            //data_atual = datetimenow;
            //dtp_Data.Value = DateTime.Now;

            //Atualizar_Lista(data);
        }

        private void tb_chave_boleto_KeyDown(object sender, KeyEventArgs e)
        {
            try { 

                if (e.KeyCode == Keys.Enter)
                {
                    //--- ADICIONEI "!BOLETO" PARA NÃO FILTRAR NO BOLETO E == 0

                    if ((tb_chave_boleto.Text.Count() != 44 && !boleto) || tb_chave_boleto.Text.Count() == 0)
                        return;

                    int result = Checar_NFE_Lancada(tb_chave_boleto.Text);

                    if (result == 1)
                    {
                        MessageBox.Show("Nota fiscal já está protocolada na data atual");
                        tb_chave_boleto.Text = "";
                        return;
                    }
                    else if(result == 3)
                    {
                        tb_chave_boleto.Text = "";
                        return;
                    }

                    if (!boleto)
                    {
                        Nota_Fiscal nfe_temp = new Nota_Fiscal(tb_chave_boleto.Text, str_conexao);

                        lb_num_nfe.Text = "N° NFE: " + nfe_temp.numero + " - " + nfe_temp.serie;
                        lb_forn.Text = "FORNECEDOR: " + nfe_temp.fornecedor;
                        lb_chegada.Text = "CHEGADA: " + nfe_temp.data + " " + nfe_temp.horario;
                        lb_valor.Text = "VALOR: ";
                        lb_vencimentos.Visible = true;
                        lbx_vencimentos.Visible = true;
                        

                        nfe = nfe_temp;

                        boleto = true;
                        tb_chave_boleto.Text = "";
                        lb_chave_boleto.Text = "BOLETO(S) - CHAVE DA NOTA PARA ENCERRAR";

                        btn_cancelar.Enabled = true;
                        btn_atualizar.Enabled = false;
                        btn_pesquisar.Enabled = false;
                        btn_relatorio.Enabled = false;
                        btn_config.Enabled = false;
                        dtp_Data.Enabled = false;
                    }
                    else
                    {
                        if (tb_chave_boleto.Text == nfe.chave)
                        {
                            boleto = false;
                            lb_num_nfe.Text = "";
                            lb_forn.Text = "";
                            lb_chegada.Text = "";
                            lb_valor.Text = "";
                            lb_vencimentos.Visible = false;
                            lbx_vencimentos.Visible = false;
                            lbx_vencimentos.Items.Clear();
                            lb_chave_boleto.Text = "CHAVE DA NOTA FISCAL";
                            tb_chave_boleto.Text = "";

                            //MessageBox.Show("NOTA FISCAL INSERIDA COM SUCESSO!");
                            //Lista_Item_NFE item_nfe = new Lista_Item_NFE(nfe);
                            //item_nfe.Dock = DockStyle.Top;
                            //painel_lista.Controls.Add(item_nfe);

                            btn_cancelar.Enabled = false;
                            btn_atualizar.Enabled = true;
                            btn_pesquisar.Enabled = true;
                            btn_relatorio.Enabled = true;
                            btn_config.Enabled = true;
                            dtp_Data.Enabled = true;
                            Inserir_NFE_Banco(nfe);

                            // --- ALTEREI A FORMA DE MOSTRAR A NOVA NOTA INSERIDA PARA TIRAR A LENTIDÃO
                            //Atualizar_Lista(data);
                            Lista_Item_NFE item_nfe = new Lista_Item_NFE(nfe, str_conexao);
                            item_nfe.Dock = DockStyle.Top;
                            painel_lista.Controls.Add(item_nfe);
                        }
                        else
                        {
                            if(tb_chave_boleto.Text.Count() != 44) // --- ADICIONADO CASO BOLETO SEJA DIFERENTE SALVAR LOG E PULAR
                            {
                                //GERANDO LOG
                                StreamWriter stw = new StreamWriter("log-boletos.txt", true);
                                stw.WriteLine("LOG BOLETO DIFERENTE - FORNECEDOR: " +
                                                nfe.fornecedor + " - NOTA: " + nfe.numero +
                                                " - DATA E HORARIO: " + nfe.data + " " + nfe.horario +
                                                " - CODIGO DO BOLETO: " + tb_chave_boleto.Text +
                                                " - CHAVE DA NOTA - " + nfe.chave + "\n");
                                stw.Close();
                                tb_chave_boleto.Text = "";
                                return;
                            }

                            nfe.AdicionarBoleto(tb_chave_boleto.Text);
                            lb_valor.Text = "VALOR: " + nfe.valor;
                            lbx_vencimentos.Items.Add(nfe.boletos[nfe.boletos.Count - 1].vencimento);
                            tb_chave_boleto.Text = "";
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void dtp_Data_ValueChanged(object sender, EventArgs e)
        {
            data = dtp_Data.Value.ToString("dd/MM/yyyy");
            if (data != data_atual)
                tb_chave_boleto.Enabled = false;
            else
                tb_chave_boleto.Enabled = true;

            Atualizar_Lista(data);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            boleto = false;
            lb_num_nfe.Text = "";
            lb_forn.Text = "";
            lb_chegada.Text = "";
            lb_valor.Text = "";
            lb_vencimentos.Visible = false;
            lbx_vencimentos.Visible = false;//ISSO GERA O BUG DO SCROL PARO FNIAL
            lbx_vencimentos.Items.Clear();
            lb_chave_boleto.Text = "CHAVE DA NOTA FISCAL";
            tb_chave_boleto.Text = "";

            if (mover)
            {
                mover = false;
                id_mover = "";
            }

            btn_cancelar.Enabled = false;
            btn_atualizar.Enabled = true;
            btn_pesquisar.Enabled = true;
            btn_relatorio.Enabled = true;
            btn_config.Enabled = true;
            dtp_Data.Enabled = true;

            tb_chave_boleto.Focus();
            //--- SO BOTEI ISSO PQ APOS INSERIR A LINHA DESTACADA ACIMA ELE JOGA O SCROL PRO FINAL
            atualizar_data();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            atualizar_data();
            tb_chave_boleto.Focus();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            Configurar config = new Configurar();
            config.ShowDialog();
            tb_chave_boleto.Focus();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa(str_conexao);
            pesquisa.ShowDialog();
            tb_chave_boleto.Focus();
        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            Imprimir imprimir = new Imprimir(str_conexao, data);
            imprimir.ShowDialog();
            tb_chave_boleto.Focus();
        }

        private void atualizar_data()
        {
            string datetimenow = DateTime.Now.ToString("dd/MM/yyyy");
            data = datetimenow;
            data_atual = datetimenow;
            dtp_Data.Value = DateTime.Now;
        }

        private void Inserir_NFE_Banco(Nota_Fiscal nfe)
        {
            try
            {
                conexao = new MySqlConnection(str_conexao);

                string strSQL = "INSERT INTO NOTA_FISCAL (CHAVE, NUMERO, SERIE, CNPJ_EMIT, MES, ANO, FORNECEDOR, VALOR, DATA_RECEBIMENTO, HORARIO_CHEGADA, STATUS)" +
                    " VALUES (@CHAVE, @NUMERO, @SERIE, @CNPJ_EMIT, @MES, @ANO, @FORNECEDOR, @VALOR, @DATA_RECEBIMENTO, @HORARIO_CHEGADA, @STATUS)";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CHAVE", nfe.chave);
                comando.Parameters.AddWithValue("@NUMERO", nfe.numero);
                comando.Parameters.AddWithValue("@SERIE", nfe.serie);
                comando.Parameters.AddWithValue("@CNPJ_EMIT", nfe.cnpj_emit);
                comando.Parameters.AddWithValue("@MES", nfe.mes);
                comando.Parameters.AddWithValue("@ANO", nfe.ano);
                comando.Parameters.AddWithValue("@FORNECEDOR", nfe.fornecedor);
                comando.Parameters.AddWithValue("@VALOR", nfe.valor.ToString());
                comando.Parameters.AddWithValue("@DATA_RECEBIMENTO", nfe.data);
                comando.Parameters.AddWithValue("@HORARIO_CHEGADA", nfe.horario);
                comando.Parameters.AddWithValue("@STATUS", "OK");

                conexao.Open();
                comando.ExecuteNonQuery();

                if (nfe.boletos.Count > 0)
                {
                    strSQL = "";
                    for (int i = 0; i < nfe.boletos.Count; i++)
                    {
                        strSQL += "INSERT INTO BOLETO (NOTA_FISCAL, VALOR, VENCIMENTO) VALUES ('" + nfe.chave + "','" + nfe.boletos[i].valor + "','" + nfe.boletos[i].vencimento + "');";
                    }
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.ExecuteNonQuery();
                }

                conexao.Close();

                if (mover)
                {
                    conexao.Open();

                    strSQL = "UPDATE NOTA_FISCAL SET STATUS = @STATUS WHERE ID = @ID";
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@STATUS", "MOVIDA");
                    comando.Parameters.AddWithValue("@ID", id_mover);

                    mover = false;
                    id_mover = "";

                    comando.ExecuteReader();
                    conexao.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void Atualizar_Lista(string data)
        {
            painel_lista.Controls.Clear();
            List<Nota_Fiscal> notas = new List<Nota_Fiscal>();
            try
            {
                conexao = new MySqlConnection(str_conexao);
                conexao.Open();

                string strSQL = "SELECT * FROM NOTA_FISCAL WHERE DATA_RECEBIMENTO = @DATA AND STATUS = @STATUS ORDER BY HORARIO_CHEGADA";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@DATA", data);
                comando.Parameters.AddWithValue("@STATUS", "OK");

                dr_notas = comando.ExecuteReader();

                while (dr_notas.Read())
                {
                    notas.Add(new Nota_Fiscal(dr_notas["id"].ToString(),
                        dr_notas["chave"].ToString(),
                        dr_notas["numero"].ToString(),
                        dr_notas["serie"].ToString(),
                        dr_notas["cnpj_emit"].ToString(),
                        dr_notas["mes"].ToString(),
                        dr_notas["ano"].ToString(),
                        dr_notas["fornecedor"].ToString(),
                        dr_notas["valor"].ToString(),
                        dr_notas["data_recebimento"].ToString(),
                        dr_notas["horario_chegada"].ToString()));
                }
                conexao.Close();

                for (int i = 0; i < notas.Count; i++)
                {
                    conexao.Open();
                    strSQL = "SELECT * FROM BOLETO WHERE NOTA_FISCAL = @CHAVE ORDER BY VENCIMENTO";
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@CHAVE", notas[i].chave);
                    dr_boletos = comando.ExecuteReader();
                    while (dr_boletos.Read())
                    {
                        notas[i].AdicionarBoletoViaBanco(dr_boletos["valor"].ToString(), dr_boletos["vencimento"].ToString());
                    }

                    Lista_Item_NFE item_nfe = new Lista_Item_NFE(notas[i], str_conexao);
                    item_nfe.Dock = DockStyle.Top;
                    painel_lista.Controls.Add(item_nfe);
                    conexao.Close();
                }

                //PROXIMO PASSO: FILTRO DE NOTA DUPLICADA, DETALHES ESTÉTICOS, GERAÇÃO DE EXCEL E IMPRESSÃO
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        //O METODO TEM 4 RETORNOS:
        //0 = NOTA NÃO LANÇADA OU EXCLUIDA
        //1 = NOTA JÁ LANÇADA NO DIA ATUAL (NÃO DEIXA LANÇAR)
        //3 = NOTA JÁ LANÇADA EM OUTRA DATA (NÃO MOVER, CANCELAR LANÇAMENTO)
        //4 = NOTA JÁ LANÇADA EM OUTRA DATA (MOVER PARA A DATA ATUAL)
        private int Checar_NFE_Lancada(string chave)
        {
            try
            {
                conexao = new MySqlConnection(str_conexao);
                conexao.Open();

                string strSQL = "SELECT * FROM NOTA_FISCAL WHERE CHAVE = @CHAVE AND STATUS = @STATUS";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CHAVE", chave);
                comando.Parameters.AddWithValue("@STATUS", "OK");

                dr_notas = comando.ExecuteReader();

                if (dr_notas.Read())
                {

                    if (dr_notas["data_recebimento"].ToString() == data_atual)
                    {
                        conexao.Close();
                        return 1;
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("A nota fiscal " + dr_notas["numero"].ToString() + " está protocolada na data de " + dr_notas["data_recebimento"].ToString() + ", deseja movê-la para a data atual?", "Nota fiscal já protocolada", MessageBoxButtons.YesNo);

                        if (dialog == DialogResult.Yes)
                        {
                            mover = true;
                            id_mover = dr_notas["id"].ToString();
                            conexao.Close();
                            return 4;
                        }
                        else
                        {
                            conexao.Close();
                            return 3;
                        }
                    }
                }

                conexao.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            return 0;
        }

    }
}
