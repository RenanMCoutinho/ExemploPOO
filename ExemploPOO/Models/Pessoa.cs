﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExemploPOO.Models
{
    internal class Pessoa
    {
        public Pessoa(string nome)
        {

            Nome = nome;

        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()
        {

            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos!");


        }
    }
}
