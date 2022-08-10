using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImposto.Aula10
{
    public class Estado
    {
        public Contrato Contrato { get; set; }

        public Estado(Contrato contrato)
        {
            this.Contrato = contrato;
        }
    }
}