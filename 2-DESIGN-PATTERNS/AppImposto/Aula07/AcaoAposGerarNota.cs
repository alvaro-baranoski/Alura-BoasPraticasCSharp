using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppImposto.Aula06;

namespace AppImposto.Aula07
{
    public interface AcaoAposGerarNota
    {
        void Executa(NotaFiscal nf);
    }
}