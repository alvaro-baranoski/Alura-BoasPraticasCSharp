using AppImposto.Aula15;

public class TesteDeImpostos 
{
    static void Main(String[] args) 
    {
        Cliente cliente = new Cliente();

        cliente.Nome = "Victor";
        cliente.Endereco = "Rua Vergueiro";
        cliente.DataNascimento = DateTime.Now;

        String xml = new GeradorDeXml().GeraXml(cliente);

        Console.WriteLine(xml);
    }
}