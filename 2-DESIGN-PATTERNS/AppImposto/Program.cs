using System.Data;
using AppImposto.Aula05;
using AppImposto.Aula06;
using AppImposto.Aula07;
using AppImposto.Aula08;
using AppImposto.Aula09;
using AppImposto.Aula10;

public class TesteDeImpostos 
{
    static void Main(String[] args) 
    {
        Historico historico = new Historico();

        Contrato c = new Contrato(DateTime.Now, "Alvaro", IContrato.Novo);
        historico.Adiciona(c.SalvaEstado());

        c.Avanca();
        historico.Adiciona(c.SalvaEstado());

        c.Avanca();
        historico.Adiciona(c.SalvaEstado());

        Console.WriteLine(historico.Pega(2).Contrato.Tipo);
    }
}