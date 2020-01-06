using System;

namespace DesignPaterns.DecoratorPattern.Models
{
    public class BlackCoffeeDecorator : DecoratorBeverages
    {
        BeverageComponent _beverageComponent;
        public decimal SmallBlackCoffeeCost = Convert.ToDecimal(0.00);
        public BlackCoffeeDecorator(BeverageComponent beverageComponent)
        {
            if (beverageComponent == null)
                _beverageComponent = new ConcreteCoffee();

        }

        public override decimal Cost()
        {
            return this._beverageComponent.Cost() + SmallBlackCoffeeCost;
        }
    }
}
