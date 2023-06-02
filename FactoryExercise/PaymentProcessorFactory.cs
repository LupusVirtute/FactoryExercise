namespace FactoryExercise;

public partial class Payment
{
    public static class PaymentProcessorFactory
    {
        public static Payment CreatePaymentWithBank(List<Product> productsToBeBought, PaymentProviderFinalPriceCalculator bank)
        {
            return new Payment(productsToBeBought, bank.GetFinalPrice(productsToBeBought));
        }

    }
}