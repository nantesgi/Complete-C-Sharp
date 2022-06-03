using System;
using System.Globalization;
using _14_ExercicioPratico1.Entities;
using _14_ExercicioPratico1.Services;

namespace _14_ExercicioPratico1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados de reserva");
            
            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();

            Console.Write("Retirada (dd/MM/yyyy HH:mm): ");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Retorno (dd/MM/yyyy): ");
            DateTime fim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Digite o valor da hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor por dia: ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ReservaCarro reservaCarro = new ReservaCarro(inicio, fim, new Veiculo(modelo));

            RentalService rentalService = new RentalService(hora, dia, new BrazilTaxService());

            rentalService.ProcessarConta(reservaCarro);

            Console.WriteLine();
            Console.WriteLine("Conta: ");
            Console.WriteLine(reservaCarro.Conta);

            Console.ReadLine();
        }
    }
}
