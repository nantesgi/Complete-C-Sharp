using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Sobreposicao.Entities;

namespace _10_Sobreposicao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conta acc1 = new Conta(1001, "Alex", 500.0);
            Conta acc2 = new ContaPoupanca(1002, "Anna", 500.0, 0.01);

            acc1.Saque(10.0);
            acc2.Saque(10.0);

            Console.WriteLine(acc1.Saldo);
            Console.WriteLine(acc1.Saldo);

            Console.ReadLine();
        }
    }
}
