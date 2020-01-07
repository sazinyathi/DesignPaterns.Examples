

using DesignPaterns.DecoratorPattern.Models.Cups;
using DesignPaterns.FactoryPattern.Managers;

namespace DesignPaterns.FactoryPattern.Factory
{
    public abstract class BaseCupsFactory
    {
        protected Cups _cups;
        public abstract ICupsManager Create();
        public BaseCupsFactory(Cups cups)
        {
            _cups = cups;
        }

        public Cups ApplyCupsCost()
        {
            ICupsManager cupsManager = this.Create();
            _cups.CostOfCup = cupsManager.CostOfSizeOfCups();
            return _cups;
        }
    }
}
