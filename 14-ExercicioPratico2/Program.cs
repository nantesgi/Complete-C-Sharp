using System;
using System.Globalization;
using _14_ExercicioPratico2.Entities;
using _14_ExercicioPratico2.Services;

namespace _14_ExercicioPratico2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os dados do contrato");

            Console.Write("Número: ");
            int numeroContrato = int.Parse(Console.ReadLine());

            Console.Write("Data (dd/MM/yyyy): ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Valor do contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira o número de parcelas: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato meuContrato = new Contrato(numeroContrato, dataContrato, valorContrato);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessoContrato(meuContrato, meses);

            Console.WriteLine("Parcelas:");
            foreach (Parcela parcela in meuContrato.Parcelas)
            {
                Console.WriteLine(parcela);
            }

            Console.ReadLine();
        }
    }
}
