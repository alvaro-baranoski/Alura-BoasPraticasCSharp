public class ICCC : Imposto 
{
    public ICCC(Imposto outroImposto) : base(outroImposto)
    {
        
    }

    public override double Calcula(Orcamento orcamento)
    {
        if (orcamento.Valor < 1000.0)
        {
            return (orcamento.Valor * 0.05);
        }
        else if (1000.0 <= orcamento.Valor && orcamento.Valor <= 3000.0)
        {
            return (orcamento.Valor * 0.07);
        }
        else
        {
            return (orcamento.Valor * 0.08) + 30.0;
        }
    }
}