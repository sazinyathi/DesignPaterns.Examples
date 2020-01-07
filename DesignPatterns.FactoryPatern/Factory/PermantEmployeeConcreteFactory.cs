using DesignPatterns.FactoryPatern.Interface;
using DesignPatterns.FactoryPatern.Managers;
using DesignPatterns.FactoryPatern.Model;

namespace DesignPatterns.FactoryPatern.Factory
{
    public class PermantEmployeeConcreteFactory : BaseEmployeeFactory
    {
        public PermantEmployeeConcreteFactory(Employee employee) : base(employee)
        {
        }

        public override IEmployeeManager CreateEmployee()
        {
            var permant = new PermantEmployeeManager();
            _employee.HouseAllowance = permant.GetHouseAllowance();
            return permant;
        }
    }
}
