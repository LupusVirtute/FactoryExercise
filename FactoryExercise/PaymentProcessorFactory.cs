namespace FactoryExercise;

public partial class Payment
{
    public static class PaymentProcessorFactory
    {
        public static Payment CreatePaymentWithBank(List<Product> productsToBeBought, PaymentGateways paymentGateway)
        {
            return new Payment(productsToBeBought, paymentGateway.GetFinalPrice(productsToBeBought));
        }

    }
}