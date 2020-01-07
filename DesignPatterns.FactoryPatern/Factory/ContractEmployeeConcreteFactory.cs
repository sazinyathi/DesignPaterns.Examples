using DesignPatterns.FactoryPatern.Interface;
using DesignPatterns.FactoryPatern.Managers;
using DesignPatterns.FactoryPatern.Model;

namespace DesignPatterns.FactoryPatern.Factory
{
    public class ContractEmployeeConcreteFactory : BaseEmployeeFactory
    {
       
        public ContractEmployeeConcreteFactory(Employee employee) : base(employee)
        {
        }

        public override IEmployeeManager CreateEmployee()
        {
            var contract = new ContractEmployeeManager();
            _employee.MedicalAllowance = contract.GetAllowance();
            return contract;
        }
    }
}
