namespace AppImposto.Aula01
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto)
        {
            
        }

        public override double Calcula(Orcamento orcamento) 
        {
            return orcamento.Valor * 0.06 + CalculoOutroImposto(orcamento);
        }
    }
}