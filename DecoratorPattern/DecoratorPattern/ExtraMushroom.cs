namespace DecoratorPattern
{
    public class ExtraMushroom : Extra
    {
        public ExtraMushroom(Pizza pizza) : base(pizza)
        {
            this.Price = 2.0m;
        }
    }
}