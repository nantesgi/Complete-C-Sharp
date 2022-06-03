using System;
using System.Globalization;

namespace _14_ExercicioPratico2.Entities
{
    public class Parcela
    {
        public DateTime DataVencimento { get; set; }
        public double Quantia { get; set; }

        public Parcela(DateTime dataVencimento, double quantia)
        {
            DataVencimento = dataVencimento;
            Quantia = quantia;
        }

        public override string ToString()
        {
            return DataVencimento.ToString("dd/MM/yyyy")
                + " - "
                + Quantia.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
