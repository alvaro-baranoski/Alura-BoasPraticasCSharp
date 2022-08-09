namespace AppImposto.Aula01
{
    public class Item
    {
        public String Nome { get; set; }
        public double Valor { get; set; }

        public Item(String nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}
