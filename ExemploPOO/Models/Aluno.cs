﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    internal class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
        }
        public double nota { get; set; }

        public override void Apresentar()
        {
            //base.Apresentar();
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos e minha nota é {nota}!");
        }

    }
}
