using System;
using _14_ExercicioPratico2.Entities;

namespace _14_ExercicioPratico2.Services
{
    public class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessoContrato(Contrato contrato, int meses)
        {
            double cotaBase = contrato.ValorTotal / meses;

            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double cotaAtualizada = cotaBase + _onlinePaymentService.Juro(cotaBase, i);
                double cotaTotal = cotaAtualizada + _onlinePaymentService.TaxaPagamento(cotaAtualizada);
                contrato.AdicionarParcela(new Parcela(data, cotaTotal));

            }
        }
    }
}
