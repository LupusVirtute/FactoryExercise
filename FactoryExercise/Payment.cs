namespace FactoryExercise
{
    public partial class Payment
    {
        private List<Product> ProductsBought { get; set; }
        public decimal FinalPrice { get; private set; }

        protected Payment(List<Product> productsBought, decimal FinalPrice)
        {
            ProductsBought = productsBought;
            this.FinalPrice = FinalPrice;
        }
    }
}
