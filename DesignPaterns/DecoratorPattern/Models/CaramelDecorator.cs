using System;

namespace DesignPaterns.DecoratorPattern
{
    public class CaramelDecorator : DecoratorBeverages
    {
        BeverageComponent _beverageComponent;
        public decimal CaramelCost = Convert.ToDecimal(12.13);
        public CaramelDecorator(BeverageComponent beverageComponent)
        {
            if (beverageComponent == null)
                this._beverageComponent = new ConcreteEspress();
        }
        public override decimal Cost()
        {
            return _beverageComponent.Cost() + CaramelCost;
        }
    }
}
