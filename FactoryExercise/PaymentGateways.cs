using Ardalis.SmartEnum;
using FactoryExercise.DoubleExtensions;
using FactoryExercise.PaymentGateway;

namespace FactoryExercise;

public sealed class PaymentGateways : SmartEnum<PaymentGateways>
{
    private IPaymentGateway PaymentGateway { get; }
    private PaymentGateways(string name, int value, IPaymentGateway paymentGateway) : base(name, value)
    {
        PaymentGateway = paymentGateway;
    }

    public double GetFinalPrice(List<Product> products) => PaymentGateway.CalculateFinalPrice(products);

    public static readonly PaymentGateways BankOne = new (nameof(BankOne), 1, new BankOnePaymentGateway());

    public static readonly PaymentGateways BankTwo = new (nameof(BankTwo), 2, new BankTwoPaymentGateway());

}
