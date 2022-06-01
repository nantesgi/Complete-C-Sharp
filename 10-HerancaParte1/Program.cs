using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_HerancaParte1.Entities;

namespace _10_HerancaParte1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaJuridica account = new ContaJuridica(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Saldo);

            //account.Balance = 200.0; // error

            Console.ReadLine();
        }
    }
}
