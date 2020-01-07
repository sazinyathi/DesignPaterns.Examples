using DesignPaterns.FactoryPattern.SimpleFactory;
using System;

namespace DesignPaterns.FactoryPattern.Managers
{
    public class SmallCupManager : ICupsManager
    {
        public decimal CostOfSizeOfCups()
        {
            return Convert.ToDecimal("0.00");
        }
    }
}
