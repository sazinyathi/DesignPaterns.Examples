using System;

namespace DesignPaterns.DecoratorPattern
{
    public class ConcreteEspress : BeverageComponent
    {
        public override decimal Cost()
        {
            return Convert.ToDecimal(23.21);
        }
    }
}
