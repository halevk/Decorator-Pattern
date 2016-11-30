namespace DecoratorPattern
{
    public abstract class Extra : Pizza
    {
        protected Pizza Pizza { get; set; }

        protected Extra(Pizza pizza)
        {
            Pizza = pizza;
        }

        public override decimal GetPrice()
        {
            return this.Price + Pizza.GetPrice();
        }
    }
}