using DesignPaterns.DecoratorPattern.Models.Cups;
using DesignPaterns.FactoryPattern.Managers;
using DesignPaterns.FactoryPattern.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns.FactoryPattern.Factory
{
    public class CupsFactory
    {
        public BaseCupsFactory CreateCups(Cups cups)
        { 
            BaseCupsFactory baseCupsFactory = null;
            if(cups.CupsSize ==(int) CupsSize.smallCupSize)
            {
                baseCupsFactory = new SmallCupsConcreteFactory(cups);
            }
            else if (cups.CupsSize == (int)CupsSize.mediumCupSize)
            {
                baseCupsFactory = new MeduimCupConcreteFactory(cups);
            }
            return baseCupsFactory;
        }
        
        public enum CupsSize
        {
            smallCupSize = 1,
            mediumCupSize = 2,
            largeCupSize = 3,
            extraLargeCupSize = 4
        }
    }
}
