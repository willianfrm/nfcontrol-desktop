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
    public partial class Configurar : Form
    {
        public Configurar()
        {
            InitializeComponent();

            StreamReader str = new StreamReader("config.txt");
            tb_servidor.Text = str.ReadLine();
            tb_banco.Text = str.ReadLine();
            tb_usuario.Text = str.ReadLine();
            tb_senha.Text = str.ReadLine();
            str.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            StreamWriter stw = new StreamWriter("config.txt");
            //stw.Write(tudo);
            stw.WriteLine(tb_servidor.Text);
            stw.WriteLine(tb_banco.Text);
            stw.WriteLine(tb_usuario.Text);
            stw.WriteLine(tb_senha.Text);

            stw.Close();

            tb_resultados.Text = "Configuração salva com sucesso, para a alteração ter efeito, reinicie a aplicação.";
        }

        private void btn_checar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao;
            string strcon = "Server = " + tb_servidor.Text +
                            "; Database = " + tb_banco.Text +
                            "; Uid = " + tb_usuario.Text +
                            "; Pwd = " + tb_senha.Text;
            try
            {

                conexao = new MySqlConnection(strcon);
                conexao.Open();
                conexao.Close();
                tb_resultados.Text = "Conexão estabelecida com sucesso!!!";
            }
            catch(Exception ex)
            {
                tb_resultados.Text = "ERRO AO TENTAR SE CONECTAR AO BANCO!!!" + ex.Message;
            }
        }

        public string StringConexao()
        {
            StreamReader str = new StreamReader("config.txt");
            string strcon = "Server = " + str.ReadLine() +
                            "; Database = " + str.ReadLine() +
                            "; Uid = " + str.ReadLine() +
                            "; Pwd = " + str.ReadLine();
            str.Close();
            return strcon;
        }
    }
}
