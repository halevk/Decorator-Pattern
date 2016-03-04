namespace DecoratorPattern
{
    public class PizzaWithCheddarChesee : ExtraBase
    {
        public PizzaWithCheddarChesee(string name, int price, IExtra extra)
            : base(name, price, extra)
        {

        }
    }
}