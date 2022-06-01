using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ExercicioPratico.Entities
{
    public class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional { get; set; }

        public FuncionarioTerceirizado()
        {
        }

        public FuncionarioTerceirizado(string nome, int horas, double valorHora, double despesaAdicional) : base(nome, horas, valorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DespesaAdicional;
        }
    }
}
