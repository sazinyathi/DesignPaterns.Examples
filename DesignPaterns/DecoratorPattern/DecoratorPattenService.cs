using DesignPaterns.DecoratorPattern.Models;
using DesignPaterns.DecoratorPattern.Models.Cups;
using DesignPaterns.FactoryPattern.Factory;

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
        private CupsFactory cupsManagerFactory;

        private CupsFactory CupsFactory
        {
            get
            {
                if(cupsManagerFactory == null)
                {
                    cupsManagerFactory = new CupsFactory();
                }
                return cupsManagerFactory;
            }
        }
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

        private decimal CostOfCupsSize(Cups cups)
        {
            var costOfCupSize = CupsFactory.CreateCups(cups).ApplyCupsCost();
            return costOfCupSize.CostOfCup;
        }
        public decimal ExpressWithDoubleShort(Cups cup,int sizeOfCup = (int)CupsSize.smallCupSize)
        {
           
            return DoubleShortDecorator.Cost() + CostOfCupsSize(cup);
        }

        public decimal ExpressWithCaramel(Cups cup,int sizeOfCup = (int)CupsSize.smallCupSize)
        {
            return CaramelDecorator.Cost() + CostOfCupsSize(cup);
        }

        public decimal ExpressWithCaramelAndDoubleShort(Cups cup,int sizeOfCup = (int)CupsSize.smallCupSize)
        {
            return DoubleShortAndCaramelDecorator.Cost() + CostOfCupsSize(cup);
        }

        public decimal BlackCoffee(Cups cup,int sizeOfCup = (int)CupsSize.smallCupSize)
        {
            return BlackCoffeeDecorator.Cost() + CostOfCupsSize(cup);
        }

        public enum CupsSize
        {
            smallCupSize =  1,
            mediumCupSize = 2,
            largeCupSize = 3,
            extraLargeCupSize = 4
        }
    }
}
