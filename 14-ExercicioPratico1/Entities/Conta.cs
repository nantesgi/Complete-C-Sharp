using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _14_ExercicioPratico1.Entities
{
    public class Conta
    {
        public double ValorBase { get; set; }
        public double Taxa { get; set; }

        public Conta(double valorBase, double taxa)
        {
            ValorBase = valorBase;
            Taxa = taxa;
        }

        public double ValorTotal
        {
            get { return ValorBase + Taxa;}
        }

        public override string ToString()
        {
            return "Valor base: "
                + ValorBase.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nValor total: "
                + ValorTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
