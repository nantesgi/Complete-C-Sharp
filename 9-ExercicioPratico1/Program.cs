using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using _9_ExercicioPratico1.Entities;
using _9_ExercicioPratico1.Entities.Enums;

namespace _9_ExercicioPratico1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do departamento: ");
            string nomeDepartamento = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Digite os dados do trabalhador");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nivel (Júnior/Pleno/Sênior): ");
            NivelTrabalhador nivel = (NivelTrabalhador)Enum.Parse(typeof(NivelTrabalhador), Console.ReadLine());

            Console.Write("Salário base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento dept = new Departamento(nomeDepartamento);
            Trabalhador trabalhador = new Trabalhador(nome, nivel, salarioBase, dept);

            Console.Write("Quantos contratos para este trabalhador? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();

                Console.WriteLine($"Digite os dados do contrato #{i}: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor da hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duração (horas): ");
                int horas = int.Parse(Console.ReadLine());

                ContratoHora contrato = new ContratoHora(data, valorHora, horas);
                trabalhador.AdicionarContrato(contrato);
            }
            Console.WriteLine();

            Console.Write("Digite o mês e o ano para calcular o ganho (MM/YYYY): ");
            string mesEAno = Console.ReadLine();
            int mes = int.Parse(mesEAno.Substring(0, 2));
            int ano = int.Parse(mesEAno.Substring(3));

            Console.WriteLine();

            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
            Console.WriteLine("Ganho para " + mesEAno + ": " + trabalhador.Ganho(ano, mes).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
