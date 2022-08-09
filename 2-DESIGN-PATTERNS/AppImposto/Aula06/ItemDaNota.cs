using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImposto.Aula06
{
    public class ItemDaNota
    {
        public String Nome { get; set; }
        public double Valor { get; set; }

        public ItemDaNota(String nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}