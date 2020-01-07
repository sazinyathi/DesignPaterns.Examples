using DesignPatterns.FactoryPatern.Interface;
using DesignPatterns.FactoryPatern.Managers;

namespace DesignPatterns.FactoryPatern.SimpleFactory
{
    public class SimpleEmployeeFactory
    {
        public IEmployeeManager CreateEmployee(int employeeType)
        {
            IEmployeeManager employeeManager = null;
            if(employeeType == 1)
            {
                employeeManager = new PermantEmployeeManager();
            }
            else if(employeeType == 2)
            {
                employeeManager = new ContractEmployeeManager();
            }
        
            return employeeManager;
        }
    }
}
