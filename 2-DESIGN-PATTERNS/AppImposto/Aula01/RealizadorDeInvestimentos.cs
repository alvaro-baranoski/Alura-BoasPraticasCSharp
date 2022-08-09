namespace AppImposto.Aula01
{
    public class RealizadorDeInvestimentos 
    {
        public void Realiza(Conta conta, Investimento investimento) 
        {
            double resultado = investimento.Calcula(conta);  
            conta.Deposita( resultado * 0.75 );
            Console.WriteLine ( "Novo saldo: " + conta.Saldo);
        }
    }
}