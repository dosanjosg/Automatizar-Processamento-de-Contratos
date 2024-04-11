namespace ContractProcessing.Entities;

interface IOnlinePaymentService 
{
    double PaymentFee (double amount);
    double Interest (double amount, int months);
}