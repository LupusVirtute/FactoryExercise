using Bogus;
using FactoryExercise;

var productList = new Faker<Product>()
    .RuleFor(u => u.Name, (f,u) => f.Commerce.ProductName())
    .RuleFor(u => u.Description, (f,u) => f.Commerce.ProductDescription())
    .RuleFor(u => u.Price, (f,u) => f.Random.Number(0, 200))
    .GenerateBetween(0, 100);

var payments = new List<Payment>();

foreach(var paymentGateWay in PaymentGateways.List)
{
    var payment = Payment.PaymentProcessorFactory.CreatePaymentWithBank(productList, paymentGateWay);
    payments.Add(payment);
    Console.WriteLine($@"Payment for paymentGateway: {paymentGateWay.Name} 
    Costs: {payment.FinalPrice} 
    Original Product Prices: {productList.Sum(x => x.Price)}");
}
