using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    internal class Professor : Pessoa
    {
        public decimal salario { get; set; }


        public void apresentarProfessor()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos e meu salário é {salario.ToString("C")}!");
        }
    }
}