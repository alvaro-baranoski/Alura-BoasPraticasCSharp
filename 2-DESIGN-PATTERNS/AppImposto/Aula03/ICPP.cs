using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppImposto.Aula01;

namespace AppImposto.Aula03
{
    public class ICPP : TemplateImpostoCondicional
    {
        public ICPP(Imposto outroImposto) : base(outroImposto)
        {
            
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}