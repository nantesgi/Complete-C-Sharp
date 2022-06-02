using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _9_Enumeracoes.Entitites;
using _9_Enumeracoes.Entitites.Enums;

namespace _9_Enumeracoes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Id = 1080,
                Momento = DateTime.Now,
                Status = StatusPedido.PagamentoPendente
            };

            Console.WriteLine(pedido);

            Console.ReadLine();
        }
    }
}
