
using ContractProcessing.Entities;

class ContractService(IOnlinePaymentService onlinePaymentService)
{
    private IOnlinePaymentService? _onlinePaymentSerive = onlinePaymentService;

    public void ProcessContract(Contract contract, int months) 
    {
        double basicQuota = contract.TotalValue / months;

        for( int i = 1; i <= months; i++) 
        {
            DateTime date = contract.Date.AddMonths(i);
            double updateQuota = basicQuota + _onlinePaymentSerive!.Interest(basicQuota, i);
            double fullQuota = updateQuota + _onlinePaymentSerive.PaymentFee(updateQuota);
            contract.AddInstallment(new Installment(date, fullQuota));
        }
    }
}