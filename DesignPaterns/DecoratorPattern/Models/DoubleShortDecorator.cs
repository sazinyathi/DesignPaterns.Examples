using System;

namespace DesignPaterns.DecoratorPattern
{
    public class DoubleShortDecorator : DecoratorBeverages
    {
        private BeverageComponent _beverageComponent;
        public decimal DoubleShortCost = Convert.ToDecimal(25.99);
        public DoubleShortDecorator(BeverageComponent beverageComponent)
        {
            if (beverageComponent == null)
            {
                this._beverageComponent = new ConcreteEspress();
            }
               
        }
        public override decimal Cost()
        {
            return this._beverageComponent.Cost() + DoubleShortCost;
        }
    }
}
