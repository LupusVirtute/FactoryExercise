namespace FactoryExercise.PaymentGateway;

public interface IPaymentGateway
{
    abstract double CalculateFinalPrice(List<Product> productsToBeBought);
}
