using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_UpcastingDowncasting.Entities;

namespace _10_UpcastingDowncasting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conta acc = new Conta(1001, "Alex", 0.0);
            ContaJuridica jacc = new ContaJuridica(1001, "Alex", 0.0, 500.00);

            // UPCASTING
            Conta acc1 = jacc;
            Conta acc2 = new ContaJuridica(1003, "Bob", 0.0, 200.0);
            Conta acc3 = new ContaPoupanca(1004, "Ana", 0.0, 0.01);

            // DOWNCASTING
            ContaJuridica acc4 = (ContaJuridica)acc2;
            acc4.Emprestimo(100.0);
            // acc2.Emprestimo(200.0); apresenta erro porque a função Emprestimo() é apenas da classe ContaJuridica, e a acc2 é do tipo Conta, tem que fazer o DOWNCASTING antes p/ dar certo

            //ContaJuridica acc5 = (ContaJuridica)acc3;
            if (acc3 is ContaJuridica) // não é verdade, então vai ignorar as instruções da condicional
            {
                ContaJuridica acc5 = (ContaJuridica)acc3;
                acc5.Emprestimo(200.0);
                Console.WriteLine("Empréstimo!");
            }

            if (acc3 is ContaPoupanca)
            {
                ContaPoupanca acc5 = (ContaPoupanca)acc3;
                // ContaPoupanca acc5 = acc3 as ContaPoupanca; Outra maneira de declarar a linha acima
                acc5.AtualizarSaldo();
                Console.WriteLine("Atualizou!");
            }

            Console.ReadLine();
        }
    }
}
