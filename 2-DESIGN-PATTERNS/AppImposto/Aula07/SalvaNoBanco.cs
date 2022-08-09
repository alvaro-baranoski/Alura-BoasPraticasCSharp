using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppImposto.Aula06;

namespace AppImposto.Aula07
{
    public class SalvaNoBanco : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Salva no banco");
        }
    }
}