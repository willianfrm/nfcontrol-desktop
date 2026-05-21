using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Recebimento_NFS
{
    public class Nota_Fiscal
    {
        public string id_banco;
        public string chave;
        public string numero;
        public string serie;
        public string cnpj_emit;
        public string mes;
        public string ano;
        public string fornecedor;
        public double valor;
        public string data;
        public string horario;
        public List<Boleto> boletos;

        public Nota_Fiscal(string chave, string str_conexao)
        {
            this.chave = chave;

            SepararChave(chave);

            fornecedor = NomeFornecedor(cnpj_emit, str_conexao);

            horario = DateTime.Now.ToString("HH:mm:ss");
            data = DateTime.Now.ToString("dd/MM/yyyy");
            boletos = new List<Boleto>();
            valor = 0;
        }
        public Nota_Fiscal(string id_banco, string chave, string numero, string serie, string cnpj_emit, string mes, string ano, string fornecedor, string valor, string data, string horario)
        {
            this.id_banco = id_banco;
            this.chave = chave;
            this.numero = numero;
            this.serie = serie;
            this.cnpj_emit = cnpj_emit;
            this.mes = mes;
            this.ano = ano;
            this.fornecedor = fornecedor;
            this.valor = Convert.ToDouble(valor);
            this.data = data;
            this.horario = horario;
            boletos = new List<Boleto>();
        }

        private void SepararChave(string chave)
        {
            for (int i = 1; i <= 44; i++)
            {
                if (i == 3 || i == 4)
                    ano += chave[i - 1];
                else if (i == 5 || i == 6)
                    mes += chave[i - 1];
                else if (i >= 7 && i <= 20)
                    cnpj_emit += chave[i - 1];
                else if (i >= 23 && i <= 25)
                    serie += chave[i - 1];
                else if (i >= 26 && i <= 34)
                    numero += chave[i - 1];
            }

            numero = Convert.ToInt32(numero).ToString();
            serie = Convert.ToInt32(serie).ToString();
            cnpj_emit = Convert.ToInt64(cnpj_emit).ToString();
        }

        public void AdicionarBoleto(string codigo)
        {
            boletos.Add(new Boleto(codigo));

            valor += boletos[boletos.Count - 1].valor;
        }
        public void AdicionarBoletoViaBanco(string valor, string vencimento)
        {
            boletos.Add(new Boleto(valor, vencimento));
        }

        private string NomeFornecedor(string cnpj, string str_conexao)
        {
            //PUXANDO NOME DO FORNECEDOR DO BANCO OFICIAL
            MySqlConnection conexao;
            MySqlCommand comando;
            MySqlDataReader dr; //USAR PARA SELECT

            try
            {
                conexao = new MySqlConnection(str_conexao);
                conexao.Open();

                string strSQL = "SELECT * FROM FORNECEDOR WHERE CNPJ = @CNPJ";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CNPJ", cnpj);

                dr = comando.ExecuteReader();

                string result;

                if (dr.Read())
                    result = Convert.ToString(dr["nome"]);
                else
                    result = "FORNECEDOR NÃO ENCONTRADO!!!";

                conexao.Close();

                return result;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro: " + ex.Message);
                return "FORNECEDOR NÃO ENCONTRADO!!!";
            }
        }
    }
}
