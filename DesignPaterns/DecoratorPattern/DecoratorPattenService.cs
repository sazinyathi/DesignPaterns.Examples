using DesignPaterns.DecoratorPattern.Models;

namespace DesignPaterns.DecoratorPattern
{
    public class DecoratorPattenService
    {
        private ConcreteEspress concreteEspress;
        private CaramelDecorator caramelDecorator;
        private DoubleShortDecorator doubleShortDecorator;
        private BeverageComponent beverageComponent;
        private DoubleShortAndCaramelDecorator doubleDoubleShortAndCaramelDecorator;
        private BlackCoffeeDecorator blackCoffeeDecorator;

        public BlackCoffeeDecorator BlackCoffeeDecorator
        {
            get
            {
                if (blackCoffeeDecorator == null)
                    blackCoffeeDecorator = new BlackCoffeeDecorator(beverageComponent);
                return blackCoffeeDecorator;
            }
        }

        public DoubleShortAndCaramelDecorator DoubleShortAndCaramelDecorator
        {
            get
            {
                if (doubleDoubleShortAndCaramelDecorator == null)
                    doubleDoubleShortAndCaramelDecorator = new DoubleShortAndCaramelDecorator(beverageComponent);
                return doubleDoubleShortAndCaramelDecorator;
            }
        }


        public DoubleShortDecorator DoubleShortDecorator
        {
            get
            {
                if (doubleShortDecorator == null)
                    doubleShortDecorator = new DoubleShortDecorator(beverageComponent);
                return doubleShortDecorator;
            }
        }

        public CaramelDecorator CaramelDecorator
        {
            get
            {
                if (caramelDecorator == null)
                    caramelDecorator = new CaramelDecorator(beverageComponent);
                return caramelDecorator;
            }
        }
        public ConcreteEspress ConcreteEspress
        {
            get
            {
                if (concreteEspress == null)
                    concreteEspress = new ConcreteEspress();
                return concreteEspress;
            }
        }

        public decimal ExpressWithDoubleShort()
        {
            return DoubleShortDecorator.Cost();
        }

        public decimal ExpressWithCaramel()
        {
            return CaramelDecorator.Cost();
        }

        public decimal ExpressWithCaramelAndDoubleShort()
        {
            return DoubleShortAndCaramelDecorator.Cost();
        }

        public decimal BlackCoffee()
        {
            return BlackCoffeeDecorator.Cost();
        }
    }
}
