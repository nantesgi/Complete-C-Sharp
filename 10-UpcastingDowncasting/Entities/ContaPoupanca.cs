using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_UpcastingDowncasting.Entities
{
    public class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca() {
        }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
    }
}
