using AppImposto.Aula05;
using AppImposto.Aula06;

public class TesteDeImpostos 
{
    static void Main(String[] args) 
    {
        NotaFiscalBuilder builder = new NotaFiscalBuilder();
        builder
            .ParaEmpresa("ICI")
            .ComCnpj("23.456.789/0001-12")
            .comItem(new ItemDaNota("Item 2", 200))
            .comItem(new ItemDaNota("Item 1", 100))
            .NaDataAtual()
            .ComObservacoes("uma obs qualquer");
            // ...

        NotaFiscal nf = builder.Constroi();

        Console.WriteLine(nf.ValorBruto);
        Console.WriteLine(nf.Impostos);
    }
}