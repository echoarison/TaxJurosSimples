using ExercicioFx.Entities;
using System;

namespace ExercicioFx.Services
{
    internal class ContractService
    {
        /*Usando a interface*/
        private IOnlinePaymentService _onlinePaymentService;

        /*Construto Padrao*/
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        //methods
        public void processContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            //fazendo um loop aonde ele calcula os mes dos juros
            for (int i = 0; i < months; i++)
            {
                //fazendo uma variavel local responsavel popr add os meses
                DateTime addMonth = contract.Date.AddMonths(i);
                //atualizando a quantia e somando com paymentsService
                double updateQuota = basicQuota + _onlinePaymentService.interest(i,basicQuota);
                //somando agora com os juros do paypal
                double totalQuota = updateQuota + _onlinePaymentService.paymentFree(updateQuota);
                //add a list de Installment
                contract.AddInstallment(new Installment(addMonth, totalQuota));
            }
        }
    }
}
