public class Orcamento
{
    public double Valor { get; set; }
    public IList<Item> Itens { get; set; }

    public Orcamento(double valor)
    {
        this.Valor = valor;
        this.Itens = new List<Item>();
    }

    public void AdicionaItem(Item item)
    {
        Itens.Add(item);
    }
}