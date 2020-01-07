namespace DesignPatterns.FactoryPatern.Model
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public decimal MedicalAllowance { get; set; }
        public decimal HouseAllowance { get; set; }
        public int EmployeeTypeId { get; set; }
    }
}
