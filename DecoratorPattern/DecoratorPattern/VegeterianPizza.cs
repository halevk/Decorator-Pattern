namespace DecoratorPattern
{
    public class VegeterianPizza : IExtra
    {
        public string Name
        {
            get { return "Basic Pizza"; }
        }

        public int Price
        {
            get { return 10; }
        }
    }
}