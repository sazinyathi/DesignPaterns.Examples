using DesignPatterns.FactoryPatern.Interface;
using DesignPatterns.FactoryPatern.Model;

namespace DesignPatterns.FactoryPatern.Factory
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _employee;
        public BaseEmployeeFactory(Employee employee)
        {
            _employee = employee;  
        }
        public abstract IEmployeeManager CreateEmployee();

        public Employee ApplySalary()
        {
            IEmployeeManager employeeManager = this.CreateEmployee();
            _employee.Bonus = employeeManager.Bonus();
            _employee.Salary = employeeManager.EmployeeSalary();
            return _employee;
        }
    }
}
