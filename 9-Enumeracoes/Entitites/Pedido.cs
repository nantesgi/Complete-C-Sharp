using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _9_Enumeracoes.Entitites.Enums;

namespace _9_Enumeracoes.Entitites
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Momento
                + ", "
                + Status;
        }
    }
}
