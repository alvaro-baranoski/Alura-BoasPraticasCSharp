using System.Data;
using AppImposto.Aula05;
using AppImposto.Aula06;
using AppImposto.Aula07;
using AppImposto.Aula08;

public class TesteDeImpostos 
{
    static void Main(String[] args) 
    {
        IDbConnection connection = new ConnectionFactory().GetConnection();
    }
}