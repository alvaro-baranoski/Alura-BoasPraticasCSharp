using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppImposto.Aula06;

namespace AppImposto.Aula07
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

        private IList<AcaoAposGerarNota> todasAcoes = new List<AcaoAposGerarNota>();

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(
                RazaoSocial,
                Cnpj,
                Data,
                ValorTotal,
                Impostos,
                TodosItens,
                Observacoes
            );

            foreach (AcaoAposGerarNota acao in todasAcoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            this.todasAcoes.Add(novaAcao);
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