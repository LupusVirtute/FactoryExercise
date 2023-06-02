namespace FactoryExercise
{
    public partial class Payment
    {
        private List<Product> ProductsBought { get; set; }
        public double FinalPrice { get; private set; }

        protected Payment(List<Product> productsBought, double FinalPrice)
        {
            ProductsBought = productsBought;
            this.FinalPrice = FinalPrice;
        }
    }
}
