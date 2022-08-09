namespace AppImposto.Aula01
{
    public class ICMS : Imposto 
    {
        public ICMS(Imposto outroImposto) : base(outroImposto)
        {
            
        }

        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.1) + 50.0;
        }
    }
}