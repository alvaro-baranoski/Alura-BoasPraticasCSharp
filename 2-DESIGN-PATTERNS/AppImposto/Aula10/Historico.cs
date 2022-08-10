using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImposto.Aula10
{
    public class Historico
    {
        public IList<Estado> Estados = new List<Estado>();

        public void Adiciona(Estado estado)
        {
            this.Estados.Add(estado);
        }

        public Estado Pega(int indice)
        {
            return Estados[indice];
        }
    }
}