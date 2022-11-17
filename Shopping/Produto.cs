﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public Produto()
        {
            Nome = "";
            Codigo = 0;
            Preco = 0;
        }
        public override string ToString()
        {
            return "Código: " + Codigo + "\nNome: " + Nome + "\nPreço: " + Preco.ToString("C") + "\n";
        }
    }
}
