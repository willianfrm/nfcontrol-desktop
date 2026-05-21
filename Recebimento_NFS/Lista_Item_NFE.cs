using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Recebimento_NFS
{
    public partial class Lista_Item_NFE : UserControl
    {
        string str_conexao;

        Nota_Fiscal nfe;

        public Lista_Item_NFE(Nota_Fiscal nfe, string str_conexao)
        {
            this.nfe = nfe;
            this.str_conexao = str_conexao;

            InitializeComponent();

            lb_numero_chave.Text = nfe.numero + " - " + nfe.serie;
            lb_fornecedor.Text = nfe.fornecedor;
            tb_chave.Text = nfe.chave;
            lb_valor.Text = "R$ " + nfe.valor.ToString();
            lb_horario.Text = "Chegada:" + nfe.data + " " + nfe.horario;

            if (nfe.boletos.Count <= 0)
                lbx_vencimentos.Items.Add("-- Sem Boletos --");
            else
            {
                for (int i = 0; i < nfe.boletos.Count; i++)
                {
                    lbx_vencimentos.Items.Add(nfe.boletos[i].vencimento + " - " + nfe.boletos[i].valor.ToString());
                }
            }
        }

        private void tb_chave_KeyDown(object sender, KeyEventArgs e)
        {
            tb_chave.Text = nfe.chave;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("A nota fiscal " + nfe.numero + " será excluida, deseja continuar?", "Exluir NFE do procotolo", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection conexao;
                    MySqlCommand comando;

                    conexao = new MySqlConnection(str_conexao);
                    conexao.Open();

                    string strSQL = "UPDATE NOTA_FISCAL SET STATUS = @STATUS WHERE ID = @ID";
                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@STATUS", "EXCLUIDA");
                    comando.Parameters.AddWithValue("@ID", nfe.id_banco);

                    comando.ExecuteReader();

                    groupBox.BackColor = Color.Salmon;
                    btn_excluir.Visible = false;

                    conexao.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
    }
}
