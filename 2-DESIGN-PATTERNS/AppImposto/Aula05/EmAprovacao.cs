using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImposto.Aula05
{
    public class EmAprovacao : EstadoDeOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Não pode");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}