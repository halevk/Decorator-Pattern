namespace DecoratorPattern
{
    public class PizzaWithPeproni : ExtraBase
    {
        public PizzaWithPeproni(string name, int price, IExtra extra)
            : base(name, price, extra)
        {
                
        }
    }
}