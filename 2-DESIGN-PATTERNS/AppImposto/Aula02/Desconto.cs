using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImposto.Aula02
{
    public interface Desconto
    {
        Desconto Proximo { get; set; }

        double Desconta(Orcamento orcamento);
    }
}