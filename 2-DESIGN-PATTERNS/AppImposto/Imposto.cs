public abstract class Imposto 
{
    public Imposto OutroImposto { get; set; }

    public Imposto (Imposto outroImposto)
    {
        this.OutroImposto = outroImposto;
    }

    public Imposto()
    {
        this.OutroImposto = null;
    }

    protected double CalculoOutroImposto(Orcamento orcamento)
    {
        if (OutroImposto == null) return 0;
        return OutroImposto.Calcula(orcamento);
    }
    
    public abstract double Calcula(Orcamento orcamento);
}      