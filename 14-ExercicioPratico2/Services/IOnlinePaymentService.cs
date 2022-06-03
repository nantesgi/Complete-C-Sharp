namespace _14_ExercicioPratico2.Services
{
    public interface IOnlinePaymentService
    {
        double TaxaPagamento(double quantia);
        double Juro(double quantia, int meses);
    }
}
