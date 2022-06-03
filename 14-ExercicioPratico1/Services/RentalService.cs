using System;
using _14_ExercicioPratico1.Entities;

namespace _14_ExercicioPratico1.Services
{
    public class RentalService
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        private ITaxService _taxService;

        public RentalService(double precoHora, double precoDia, ITaxService taxService)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            _taxService = taxService;
        }

        public void ProcessarConta(ReservaCarro reservaCarro)
        {
            TimeSpan duracao = reservaCarro.Fim.Subtract(reservaCarro.Inicio);

            double valorBase = 0.0;

            if (duracao.TotalHours <= 12)
            {
                valorBase = PrecoHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                valorBase = PrecoDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _taxService.Taxa(valorBase);

            reservaCarro.Conta = new Conta(valorBase, taxa);
        }
    }
}
