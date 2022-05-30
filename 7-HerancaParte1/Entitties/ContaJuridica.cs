using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_HerancaParte1.Entitties
{
    public class ContaJuridica : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaJuridica()
        {
        }

        public ContaJuridica(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double quantia)
        {
            if (quantia <= LimiteEmprestimo)
            {
                Saldo += quantia;
            }
        }
    }
}
