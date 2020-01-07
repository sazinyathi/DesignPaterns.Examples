using DesignPatterns.FactoryPatern.Interface;

namespace DesignPatterns.FactoryPatern.Managers
{
    public class PermantEmployeeManager : IEmployeeManager
    {
        public decimal Bonus()
        {
            return 100;
        }

        public decimal EmployeeSalary()
        {
            return 3290;
        }
        public decimal GetHouseAllowance()
        {
            return 1122;
        }
    }
}
