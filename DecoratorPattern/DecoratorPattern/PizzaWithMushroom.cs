namespace DecoratorPattern
{
    public class PizzaWithMushroom : ExtraBase
    {
        public PizzaWithMushroom(string name, int price, IExtra extra)
            : base(name, price, extra)
        {
                
        }
    }
}