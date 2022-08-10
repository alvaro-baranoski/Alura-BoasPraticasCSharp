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

public class TesteDeImpostos 
{
    static void Main(String[] args) 
    {
        IEnviador enviador = new EnviaPorSms();
        IMensagem mensagem = new MensagemAdmin("Alvaro", enviador);
        mensagem.Envia();
    }
}