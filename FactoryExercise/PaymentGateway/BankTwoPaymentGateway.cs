using FactoryExercise.DoubleExtensions;

namespace FactoryExercise.PaymentGateway;

internal class BankTwoPaymentGateway : IPaymentGateway
{
    public double CalculateFinalPrice(List<Product> productsToBeBought)
    {
        double totalProductsPrice = productsToBeBought.Sum(x => x.Price);
        return totalProductsPrice * 1.02;
    }
}
