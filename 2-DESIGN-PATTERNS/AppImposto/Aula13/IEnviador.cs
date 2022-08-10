using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImposto.Aula13
{
    public interface IEnviador
    {
        public void Envia(IMensagem mensagem);
    }
}