using System;

namespace DesignPaterns.StrategyPattern
{
    public class CreateEmployees : ICreateEmployee
    {
        public string Name { get; set; }
        public void CreateEmployee()
        {
            var employees = new CreateEmployees { Name = "Sazi" };
            Console.WriteLine("Create Employee {0}",employees.Name);
        }
    }
}
