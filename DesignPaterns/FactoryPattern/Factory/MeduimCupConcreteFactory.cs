using System;
using DesignPaterns.DecoratorPattern.Models.Cups;
using DesignPaterns.FactoryPattern.Managers;

namespace DesignPaterns.FactoryPattern.Factory
{
    public class MeduimCupConcreteFactory : BaseCupsFactory
    {
        public MeduimCupConcreteFactory(Cups cups) : base(cups)
        {
        }

        public override ICupsManager Create()
        {
            var meduimCups = new MeduimCupManager();
            return meduimCups;
        }
    }
}
