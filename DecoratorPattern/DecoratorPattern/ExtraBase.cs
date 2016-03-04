namespace DecoratorPattern
{
    public abstract class ExtraBase : IExtra
    {
        protected string _name;
        protected int _price;

        protected IExtra _extra;

        protected ExtraBase(string name, int price, IExtra extra)
        {
            _name = name;
            _price = price;
            _extra = extra;
        }


        public string Name
        {
            get { return _extra.Name + " with " + _name; }
        }

        public int Price
        {
            get { return _price + _extra.Price; }
        }
    }
}