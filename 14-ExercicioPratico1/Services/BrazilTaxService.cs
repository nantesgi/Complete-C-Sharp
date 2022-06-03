namespace _14_ExercicioPratico1.Services
{
    public class BrazilTaxService : ITaxService
    {
        public double Taxa(double quantia)
        {
            if (quantia <= 100)
            {
                return quantia * 0.2;
            }
            else
            {
                return quantia * 0.15;
            }
        }
    }
}
