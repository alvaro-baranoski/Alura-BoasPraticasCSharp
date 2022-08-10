using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppImposto.Aula10
{
    public class Contrato
    {
        public DateTime Data { get; set; }
        public string Cliente { get; set; }
        public IContrato Tipo { get; set; }

        public Contrato(DateTime data, string cliente, IContrato tipo)
        {
            this.Data = data;
            this.Cliente = cliente;
            this.Tipo = tipo;
        }

        public void Avanca()
        {
            if (this.Tipo == IContrato.Novo)
            {
                this.Tipo = IContrato.EmAndamento;
            }
            else if (this.Tipo == IContrato.EmAndamento)
            {
                this.Tipo = IContrato.Acertado;
            }
            else if (this.Tipo == IContrato.Acertado)
            {
                this.Tipo = IContrato.Concluido;
            }
        }

        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(this.Data, this.Cliente, this.Tipo));
        }
    }
}