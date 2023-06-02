using Ardalis.SmartEnum;

namespace FactoryExercise
{
    public sealed class PaymentProviderFinalPriceCalculator : SmartEnum<PaymentProviderFinalPriceCalculator>
    {
        private Func<List<Product>, decimal> CalculateFinalPrice { get; }
        private PaymentProviderFinalPriceCalculator(string name, int value, Func<List<Product>, decimal> calculateFinalPrice) : base(name, value)
        {
            CalculateFinalPrice = calculateFinalPrice;
        }

        public decimal GetFinalPrice(List<Product> products) => this.CalculateFinalPrice(products);

        public static readonly PaymentProviderFinalPriceCalculator BankOne = new (nameof(BankOne), 1, x => {
            const decimal provisionThreshold = 50;
            var totalShoppingProductsValue = x.Sum(y => y.Price);
            if(totalShoppingProductsValue < provisionThreshold)
            {
                return totalShoppingProductsValue * 1.02.ToDecimal();
            }
            return totalShoppingProductsValue * 1.01.ToDecimal();
        });

        public static readonly PaymentProviderFinalPriceCalculator BankTwo = new (nameof(BankTwo), 2, x => x.Sum(y => y.Price * 1.01.ToDecimal()));

    }
}
