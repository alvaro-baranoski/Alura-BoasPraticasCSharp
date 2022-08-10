using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImposto.Aula13
{
    public class MensagemCliente : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }

        public MensagemCliente(string nome, IEnviador enviador)
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
            return string.Format("Enviando mensagem para o cliente {0}", nome);
        }
    }
}