using PirkiniuKrepselisCore.Contracts;

namespace PirkiniuKrepselisCore.Services
{
    public class PaymentService
    {
        public void ProcessPayment(IPaymentProcessor paymentProcessor, decimal amount)
        {
            paymentProcessor.ProcessPayment(amount);
        }
    }
}