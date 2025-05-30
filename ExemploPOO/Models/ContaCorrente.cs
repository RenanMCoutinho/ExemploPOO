using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    internal class ContaCorrente
    {

        public ContaCorrente(int NumeroConta, decimal saldoInicial)
        {

            NumeroConta = numeroConta;
            saldoConta = saldoInicial;

        }
        public int numeroConta { get; set; }

        private decimal saldoConta;

        public void sacarValor(decimal valor)
        {
            if (saldoConta >= valor)
            {
                saldoConta = valor;
                Console.WriteLine($"Saque no valor de {valor.ToString("C")} realizado com sucesso!");

            }
            else
            {
                Console.WriteLine($"Não foi possivel realizar o saque de {valor.ToString("C")}, valor maior que o saldo de {saldoConta.ToString("C")} disponivel !");
            }
        }

        public void exibirSaldo()
        {
            Console.WriteLine($"Saldo Disponivel: {saldoConta.ToString("C")}");

        }



    }
}
