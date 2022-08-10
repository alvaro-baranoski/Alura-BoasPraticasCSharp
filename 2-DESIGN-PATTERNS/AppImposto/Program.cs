using System.Data;
using AppImposto.Aula05;
using AppImposto.Aula06;
using AppImposto.Aula07;
using AppImposto.Aula08;
using AppImposto.Aula09;
using AppImposto.Aula10;
using AppImposto.Aula11;
using AppImposto.Aula12;
using AppImposto.Aula13;
using AppImposto.Aula14;

public class TesteDeImpostos 
{
    static void Main(String[] args) 
    {
        Fila fila = new Fila();
        Pedido pedido1 = new Pedido("Alvaro", 100.0);
        Pedido pedido2 = new Pedido("Mauricio", 100.0);

        fila.Adiciona(new PagaPedido(pedido1));
        fila.Adiciona(new PagaPedido(pedido2));

        fila.Adiciona(new FinalizaPedido(pedido1));

        fila.Processa();
    }
}