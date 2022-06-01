using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ExercicioPratico.Entities
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorHora { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora; 
        }

        public virtual double Pagamento()
        {
            return Horas * ValorHora;
        }
    }
}
