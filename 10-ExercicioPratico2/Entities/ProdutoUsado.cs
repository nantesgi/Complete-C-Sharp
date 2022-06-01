using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _10_ExercicioPratico2.Entities
{
    public class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string PrecoEtiqueta()
        {
            return Nome 
                + "(usado): R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " Data de fabricação: " 
                + DataFabricacao.ToString("dd/MM/yyyy");
        }
    }
}
