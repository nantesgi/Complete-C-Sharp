using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using _10_ExercicioPratico.Entities;

namespace _10_ExercicioPratico
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.Write("Digite o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Dados funcionário #{i}");
                Console.Write("Terceirizado? (s/n) ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("Valor da hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (ch == 's')
                {
                    Console.Write("Despesa adicional: ");
                    double despesaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new FuncionarioTerceirizado(nome, horas, valorHora, despesaAdicional));
                }
                else
                {
                    list.Add(new Funcionario(nome, horas, valorHora));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos:");
            foreach (Funcionario func in list)
            {
                Console.WriteLine(func.Nome + " - R$ " + func.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
