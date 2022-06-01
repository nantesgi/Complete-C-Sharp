using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _10_ExercicioPratico2.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string PrecoEtiqueta()
        {
            return Nome
                + ": R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
