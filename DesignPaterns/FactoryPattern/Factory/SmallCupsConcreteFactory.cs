using DesignPaterns.DecoratorPattern.Models.Cups;
using DesignPaterns.FactoryPattern.Factory;
using DesignPaterns.FactoryPattern.Managers;

namespace DesignPaterns.FactoryPattern.SimpleFactory
{
    public class SmallCupsConcreteFactory : BaseCupsFactory
    {
        public SmallCupsConcreteFactory(Cups cups) : base(cups)
        {
        }

        public override ICupsManager Create()
        {
            var smallCup = new SmallCupManager();
            return smallCup;
        }
    }
}
