using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recebimento_NFS
{
    public class Boleto
    {
        string codigo;
        public double valor;
        int fator_de_vencimento;
        public string vencimento;

        public Boleto(string codigo)
        {
            this.codigo = codigo;

            SepararCodigo(codigo);

            //DateTime database = new DateTime(1997, 10, 07);
            //vencimento = database.AddDays(fator_de_vencimento).ToString("dd/MM/yyyy");

            //alterado devido ao limite no fator de vencimento reiniciado para 1000
            //https://ndmais.com.br/economia/boletos-com-vencimento-apos-21-02-podem-parar-de-funcionar-entenda
            //nesse caso tera que subtrair 1000 do fator de vencimento e nova database 22/02/25
            DateTime database = new DateTime(2025, 02, 22);
            vencimento = database.AddDays(fator_de_vencimento - 1000).ToString("dd/MM/yyyy");
        }
        public Boleto(string valor, string vencimento)
        {
            this.valor = Convert.ToDouble(valor);
            this.vencimento = vencimento;
        }

        private void SepararCodigo(string codigo)
        {
            string fvenc = "", val = "", cent = "";

            for (int i = 1; i <= 44; i++)
            {
                if (i >= 6 && i <= 9)
                    fvenc += codigo[i - 1];
                else if (i >= 10 && i <= 17)
                    val += codigo[i - 1];
                else if (i == 18 || i == 19)
                    cent += codigo[i - 1];
            }

            fator_de_vencimento = Convert.ToInt32(fvenc);
            valor = Convert.ToDouble(val + "," + cent);
        }
    }
}
