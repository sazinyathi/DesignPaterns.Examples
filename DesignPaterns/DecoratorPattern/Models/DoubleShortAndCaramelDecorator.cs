using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns.DecoratorPattern.Models
{
    public class DoubleShortAndCaramelDecorator : DecoratorDoubleShortAndCaramel
    {
        private BeverageComponent _beverageComponent;
        private CaramelDecorator _caramelDecorator;
        private DoubleShortDecorator _doubleShortDecorator;
        public DoubleShortAndCaramelDecorator(BeverageComponent beverageComponent)
        {
            if (beverageComponent == null)
            {
                this._beverageComponent = new ConcreteEspress();
            }
            _caramelDecorator = new CaramelDecorator(this._beverageComponent);
            _doubleShortDecorator = new DoubleShortDecorator(this._beverageComponent);
        }

       
        public override decimal Cost()
        {
            return this._beverageComponent.Cost() + this._caramelDecorator.CaramelCost + this._doubleShortDecorator.DoubleShortCost;
        }
    }
}
