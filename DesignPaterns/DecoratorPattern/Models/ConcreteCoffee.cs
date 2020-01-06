using System;

namespace DesignPaterns.DecoratorPattern.Models
{
    public class ConcreteCoffee : BeverageComponent
    {
        public override decimal Cost()
        {
            return Convert.ToDecimal(9.60);
        }
    }
}
