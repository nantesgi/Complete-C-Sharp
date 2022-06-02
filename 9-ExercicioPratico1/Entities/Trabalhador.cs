using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _9_ExercicioPratico1.Entities.Enums;

namespace _9_ExercicioPratico1.Entities
{
    public class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoHora> Contratos { get; set; } = new List<ContratoHora>(); // para representar o * do diagrama

        public Trabalhador()
        {
        }

        public Trabalhador(string nome, NivelTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarContrato(ContratoHora contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(ContratoHora contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Ganho(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach (ContratoHora contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }
    }
}
