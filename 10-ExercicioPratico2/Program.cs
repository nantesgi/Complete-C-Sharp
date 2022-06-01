using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using _10_ExercicioPratico2.Entities;

namespace _10_ExercicioPratico2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            Console.Write("Digite o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Dados do produto #{i}");
                Console.Write("Comum, usado ou importado? (c/u/i) ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine());

                if (ch == 'c')
                {
                    list.Add(new Produto(nome, preco));
                }
                if (ch == 'u')
                {
                    Console.Write("Data de fabricação: ");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                    list.Add(new ProdutoUsado(nome, preco, dataFabricacao));
                }
                if (ch == 'i')
                {
                    Console.Write("Taxa alfândega: ");
                    double taxaAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ProdutoImportado(nome, preco, taxaAlfandega));
                }
            }

            Console.WriteLine();

            Console.WriteLine("Etiquetas:");
            foreach (Produto prod in list)
            {
                Console.WriteLine(prod.PrecoEtiqueta());
            }

            Console.ReadLine();
        }
    }
}
