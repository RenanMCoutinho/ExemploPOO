using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    internal class Diretor : Professor
    {
        public Diretor(string nome) : base(nome)
        {
        }  

        public override void Apresentar()
        {
            //base.Apresentar();
            Console.WriteLine("Diretor");
        }


    }
}
