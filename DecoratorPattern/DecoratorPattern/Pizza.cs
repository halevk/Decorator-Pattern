namespace DecoratorPattern
{
    public abstract class Pizza
    {
        public decimal Price { get; set; }

        public virtual decimal GetPrice()
        {
            return this.Price;
        }
    }
}