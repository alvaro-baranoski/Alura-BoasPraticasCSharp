using AppImposto.Aula05;
using AppImposto.Aula06;
using AppImposto.Aula07;

public class TesteDeImpostos 
{
    static void Main(String[] args) 
    {
        var builder = new AppImposto.Aula07.NotaFiscalBuilder();
        builder
            .ParaEmpresa("ICI")
            .ComCnpj("23.456.789/0001-12")
            .comItem(new ItemDaNota("Item 2", 200))
            .comItem(new ItemDaNota("Item 1", 100))
            .NaDataAtual()
            .ComObservacoes("uma obs qualquer");
            // ...

        builder.AdicionaAcao(new EnviadorDeEmail());
        builder.AdicionaAcao(new SalvaNoBanco());
        builder.AdicionaAcao(new EnviadorDeSms());

        NotaFiscal nf = builder.Constroi();

        Console.WriteLine(nf.ValorBruto);
        Console.WriteLine(nf.Impostos);
    }
}