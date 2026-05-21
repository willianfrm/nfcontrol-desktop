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
    public partial class Pesquisa : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr_notas;
        string str_conexao;

        public Pesquisa(string str_conexao)
        {
            this.str_conexao = str_conexao;

            InitializeComponent();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            lv_lista_notas.Items.Clear();

            try
            {
                string numero, cnpj_forn, valor;

                if (tb_num_nota.Text == "" && tb_cnpj_forn.Text == "" && tb_valor.Text == "")
                {
                    MessageBox.Show("Nenhuma informação foi inserida para pesquisa!!!");
                    return;
                }

                numero = tb_num_nota.Text;
                cnpj_forn = tb_cnpj_forn.Text;
                valor = tb_valor.Text;

                string sql = "SELECT * FROM NOTA_FISCAL WHERE ";

                if (numero != "")   //SE O NUMERO NÃO FOR VAZIO
                    sql += "NUMERO = @NUMERO ";

                if (cnpj_forn != "" && numero == "")    //SE O CNPJ NÃO FOR VAZIO E O NUMERO VAZIO
                    sql += "CNPJ_EMIT = @CNPJ ";
                else if (cnpj_forn != "")   //SE O CNPJ NÃO FOR VAZIO NEM O NUMERO
                    sql += "AND CNPJ_EMIT = @CNPJ ";

                if (valor != "" && cnpj_forn == "" && numero == "")
                    sql += "VALOR = @VALOR ";
                else if (valor != "")
                    sql += "AND VALOR = @VALOR ";

                conexao = new MySqlConnection(str_conexao);
                conexao.Open();

                string strSQL = sql;
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NUMERO", numero);
                comando.Parameters.AddWithValue("@CNPJ", cnpj_forn);
                comando.Parameters.AddWithValue("@VALOR", valor);

                dr_notas = comando.ExecuteReader();

                while (dr_notas.Read())
                {
                    ListViewItem lvi = new ListViewItem(dr_notas["numero"].ToString());
                    lvi.SubItems.Add(dr_notas["serie"].ToString());
                    lvi.SubItems.Add(dr_notas["fornecedor"].ToString());
                    lvi.SubItems.Add(dr_notas["cnpj_emit"].ToString());
                    lvi.SubItems.Add(dr_notas["data_recebimento"].ToString());
                    lvi.SubItems.Add(dr_notas["horario_chegada"].ToString());
                    lvi.SubItems.Add(dr_notas["valor"].ToString());
                    lvi.SubItems.Add(dr_notas["status"].ToString());
                    lvi.SubItems.Add(dr_notas["chave"].ToString());

                    lv_lista_notas.Items.Add(lvi);
                }
                conexao.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
