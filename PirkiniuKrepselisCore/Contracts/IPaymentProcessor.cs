namespace PirkiniuKrepselisCore.Contracts
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}