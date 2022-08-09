using AppImposto.Aula02;

public class TesteDeImpostos 
{
    static void Main(String[] args) 
    {
        CalculadorDeDescontos calculador = new CalculadorDeDescontos();

        Orcamento orcamento = new Orcamento(500);
        orcamento.AdicionaItem(new Item("CANETA", 250));
        orcamento.AdicionaItem(new Item("LAPIS", 250));
        orcamento.AdicionaItem(new Item("GELADEIRA", 250));
        orcamento.AdicionaItem(new Item("MORANGO", 250));
        orcamento.AdicionaItem(new Item("PISTACHE", 250));
        orcamento.AdicionaItem(new Item("CHUTEIRA", 250));

        
        double desconto = calculador.Calcula(orcamento);

        Console.WriteLine(desconto);

    }
}