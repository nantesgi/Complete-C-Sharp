namespace _14_ExercicioPratico2.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        private const double TaxaPorcentagem = 0.02;
        private const double JuroMensal = 0.01;

        public double TaxaPagamento(double quantia)
        {
            return quantia * TaxaPorcentagem;
        }

        public double Juro(double quantia, int meses)
        {
            return quantia * JuroMensal * meses;
        }
    }
}
