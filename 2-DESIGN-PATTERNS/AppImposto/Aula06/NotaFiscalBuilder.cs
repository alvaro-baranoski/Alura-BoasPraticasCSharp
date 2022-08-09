using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImposto.Aula06
{
    public class NotaFiscalBuilder
    {
        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public double ValorTotal { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> TodosItens = new List<ItemDaNota>();
        public String Observacoes { get; set; }
        public DateTime Data { get; set; }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(
                RazaoSocial,
                Cnpj,
                Data,
                ValorTotal,
                Impostos,
                TodosItens,
                Observacoes
            );
        }

        public NotaFiscalBuilder ParaEmpresa(String razaoSocial) 
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String obsevacoes)
        {
            this.Observacoes = obsevacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder comItem(ItemDaNota item)
        {
            TodosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }
    }
}