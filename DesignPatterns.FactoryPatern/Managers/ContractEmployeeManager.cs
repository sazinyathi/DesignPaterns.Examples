using DesignPatterns.FactoryPatern.Interface;

namespace DesignPatterns.FactoryPatern.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal Bonus()
        {
            return 25;
        }

        public decimal EmployeeSalary()
        {
            return 1500;
        }

        public decimal GetAllowance()
        {
            return 12;
        }
    }
}
