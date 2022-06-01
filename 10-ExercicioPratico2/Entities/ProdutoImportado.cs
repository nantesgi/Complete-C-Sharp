using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _10_ExercicioPratico2.Entities
{
    public class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaAlfandega) : base(nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public double ValorTotal()
        {
            return Preco + TaxaAlfandega;
        }

        public override string PrecoEtiqueta()
        {
            return Nome 
                + ": R$"
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture)
                + " Taxa alfândega: R$ " + TaxaAlfandega.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
