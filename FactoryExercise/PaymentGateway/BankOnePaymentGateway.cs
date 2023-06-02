using FactoryExercise.DoubleExtensions;

namespace FactoryExercise.PaymentGateway;

internal class BankOnePaymentGateway : IPaymentGateway
{
    public double CalculateFinalPrice(List<Product> productsToBeBought)
    {
        const double provisionThreshold = 50;
        var totalShoppingProductsValue = productsToBeBought.Sum(y => y.Price);
        if (totalShoppingProductsValue < provisionThreshold)
        {
            return totalShoppingProductsValue * 1.02;
        }
        return totalShoppingProductsValue * 1.01;
    }
}
