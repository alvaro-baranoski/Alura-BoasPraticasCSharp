using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImposto.Aula05
{
    public class Finalizado : EstadoDeOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Desconto não disponível");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("não da");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("não da");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("não da");
        }
    }
}