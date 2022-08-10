using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImposto.Aula14
{
    public class Fila
    {
        private IList<IComando> comandos = new List<IComando>();

        public void Adiciona(IComando comando)
        {
            this.comandos.Add(comando);
        }

        public void Processa()
        {
            foreach (var comando in this.comandos)
            {
                comando.Executa();
            }
        }
    }
}