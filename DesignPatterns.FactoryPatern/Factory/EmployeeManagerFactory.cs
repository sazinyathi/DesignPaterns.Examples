using DesignPatterns.FactoryPatern.Model;

namespace DesignPatterns.FactoryPatern.Factory
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee employee)
        {
            BaseEmployeeFactory baseEmployeeFactory = null;
            if(employee.EmployeeTypeId == 1)
            {
                baseEmployeeFactory = new PermantEmployeeConcreteFactory(employee);
            }
            else if (employee.EmployeeTypeId == 2)
            {
                baseEmployeeFactory = new ContractEmployeeConcreteFactory(employee);
            }
            return baseEmployeeFactory;
        }
    }
}
