using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _6_ListasParte2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List <Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionario #" + i + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, salario));

                Console.WriteLine();

                Console.Write("Digite o Id do funcionário que terá o salário aumentado: ");
                int buscaID = int.Parse(Console.ReadLine());

                Funcionario func = list.Find(x => x.Id == buscaID);

                if (func != null)
                {
                    Console.WriteLine("Informe a porcentagem: ");
                    double porcentagem = int.Parse(Console.ReadLine());
                    func.aumentarSalario(porcentagem);
                }
                else
                {
                    Console.WriteLine("Este Id não existe!");
                }

                Console.WriteLine();

                Console.WriteLine("Lista atualizada de funcionários: ");
                foreach (Funcionario obj in list)
                {
                    Console.WriteLine(obj);
                }

                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
