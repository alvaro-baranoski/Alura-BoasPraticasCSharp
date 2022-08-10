using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImposto.Aula13
{
    public class MensagemAdmin : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }

        public MensagemAdmin(string nome, IEnviador enviador)
        {
            this.nome = nome;
            this.Enviador = enviador;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando mensagem para o admin {0}", nome);
        }
    }
}