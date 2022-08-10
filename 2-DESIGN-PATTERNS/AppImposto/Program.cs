using System.Data;
using AppImposto.Aula05;
using AppImposto.Aula06;
using AppImposto.Aula07;
using AppImposto.Aula08;
using AppImposto.Aula09;
using AppImposto.Aula10;
using AppImposto.Aula11;

public class TesteDeImpostos 
{
    static void Main(String[] args) 
    {
        // (1 + 10) + (20 - 10)
        IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
        IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
        IExpressao soma = new Soma(esquerda, direita);

        Console.WriteLine(soma.Avalia());
    }
}