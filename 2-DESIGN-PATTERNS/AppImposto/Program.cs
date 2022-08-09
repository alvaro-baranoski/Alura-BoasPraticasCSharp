public class TesteDeImpostos 
{
    static void Main(String[] args) 
    {
        Imposto iss = new ISS();
        Imposto icms = new ICMS();
        Imposto iccc = new ICCC();
        Orcamento orcamento = new Orcamento(500.0);
        CalculadorDeImpostos calculador = new CalculadorDeImpostos();

        // Calculando o ISS
        calculador.RealizaCalculo(orcamento, iss);

        // Calculando o ICMS        
        calculador.RealizaCalculo(orcamento, icms);

        // Calculando o ICCC        
        calculador.RealizaCalculo(orcamento, iccc);

    }
}