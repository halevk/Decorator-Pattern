namespace DecoratorPattern
{
    public class ExtraOlive : Extra
    {
        public ExtraOlive(Pizza pizza) : base(pizza)
        {
            this.Price = 3.0m;
        }
    }
}