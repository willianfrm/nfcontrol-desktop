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
using System.Drawing.Printing;

namespace Recebimento_NFS
{
    public partial class Imprimir : Form
    {
        string str_conexao;
        string data_rec;
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr_notas;

        Bitmap bmp;

        List<Nota_Fiscal> notas = new List<Nota_Fiscal>();
        int contItensPage = 0;
        int contPages = 1;

        public Imprimir(string str_conexao, string data)
        {
            this.str_conexao = str_conexao;
            this.data_rec = data;

            InitializeComponent();

            try
            {
                conexao = new MySqlConnection(str_conexao);
                conexao.Open();

                string strSQL = "SELECT * FROM NOTA_FISCAL WHERE DATA_RECEBIMENTO = @DATA AND STATUS = @STATUS";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@DATA", data_rec);
                comando.Parameters.AddWithValue("@STATUS", "OK");

                dr_notas = comando.ExecuteReader();
                
                while (dr_notas.Read())
                {
                    /*ListViewItem lvi = new ListViewItem(dr_notas["numero"].ToString());
                    lvi.SubItems.Add(dr_notas["serie"].ToString());
                    lvi.SubItems.Add(dr_notas["fornecedor"].ToString());
                    lvi.SubItems.Add(dr_notas["cnpj_emit"].ToString());
                    lvi.SubItems.Add(dr_notas["data_recebimento"].ToString());
                    lvi.SubItems.Add(dr_notas["horario_chegada"].ToString());
                    lvi.SubItems.Add(dr_notas["valor"].ToString());
                    lv_lista_notas_dia.Items.Add(lvi);*/

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            lb_impressora.Text = "Impressora: " + (new PrinterSettings()).PrinterName;
            AtualizarLista();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //printDocument1.PrinterSettings.ToPage = 2;
            //e.HasMorePages = true;
            lv_lista_notas_dia.Items.Clear();

            while (contItensPage < (61 * contPages) && contItensPage < notas.Count)//61 ITEMS POR PÁGINA
            {
                ListViewItem lvi = new ListViewItem(notas[contItensPage].numero);
                lvi.SubItems.Add(notas[contItensPage].serie);
                lvi.SubItems.Add(notas[contItensPage].fornecedor);
                lvi.SubItems.Add(notas[contItensPage].cnpj_emit);
                lvi.SubItems.Add(notas[contItensPage].data);
                lvi.SubItems.Add(notas[contItensPage].horario);
                lvi.SubItems.Add(notas[contItensPage].valor.ToString());
                lv_lista_notas_dia.Items.Add(lvi);
                contItensPage++;
            }

            bmp = new Bitmap(lv_lista_notas_dia.Width, lv_lista_notas_dia.Height);
            lv_lista_notas_dia.DrawToBitmap(bmp, new Rectangle(0, 0, lv_lista_notas_dia.Width, lv_lista_notas_dia.Height));
            e.Graphics.DrawImage(bmp, 50, 25);

            if (contItensPage < notas.Count)
            {
                e.HasMorePages = true;
                contPages++;
            }
            else
            {
                e.HasMorePages = false;
                contItensPage = 0;
                contPages = 1;
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            /*Graphics g = lv_lista_notas_dia.CreateGraphics();
            bmp = new Bitmap(lv_lista_notas_dia.Width, lv_lista_notas_dia.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(lv_lista_notas_dia.Location.X, lv_lista_notas_dia.Location.Y, 0, 0, lv_lista_notas_dia.Size);
            printPreviewDialog1.ShowDialog();*/

            /*int height = lv_lista_notas_dia.Height;
            lv_lista_notas_dia.Height = /lv_lista_notas_dia.Items.Count * 19/1080;
            bmp = new Bitmap(lv_lista_notas_dia.Width, lv_lista_notas_dia.Height);
            lv_lista_notas_dia.DrawToBitmap(bmp, new Rectangle(0, 0, lv_lista_notas_dia.Width, lv_lista_notas_dia.Height));
            lv_lista_notas_dia.Height = height;*/

            int height = lv_lista_notas_dia.Height;
            lv_lista_notas_dia.Height = 1080;

            printPreviewDialog1.ShowDialog();

            lv_lista_notas_dia.Height = height;

            AtualizarLista();
        }

        private void AtualizarLista()
        {
            lv_lista_notas_dia.Items.Clear();

            for(int i = 0; i < notas.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(notas[i].numero);
                lvi.SubItems.Add(notas[i].serie);
                lvi.SubItems.Add(notas[i].fornecedor);
                lvi.SubItems.Add(notas[i].cnpj_emit);
                lvi.SubItems.Add(notas[i].data);
                lvi.SubItems.Add(notas[i].horario);
                lvi.SubItems.Add(notas[i].valor.ToString());
                lv_lista_notas_dia.Items.Add(lvi);
            }
        }
    }
}
