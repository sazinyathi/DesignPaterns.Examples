namespace DesignPaterns.StrategyPattern
{
    public class Employee
    {
        public ICreateEmployee _createEmployee { get; private set;}
        public ICalculateBonus _calculateBonus { get; set; }

        public ICalculateBonus CalculateBonus
        {
            get
            {
                if (_calculateBonus == null)
                    _calculateBonus = new CalculateBonus();
                return _calculateBonus;
            }

        }
        public ICreateEmployee CreateEmployees
        {
            get
            {
                if (_createEmployee == null)
                    _createEmployee = new CreateEmployees();
                return _createEmployee;
            }
            
        }
        public Employee(CreateEmployees createEmployee)
        {
            this._createEmployee = createEmployee;
        }
        public Employee()
        {
            if (_createEmployee == null && _calculateBonus == null)
                _createEmployee = CreateEmployees;
            _calculateBonus = CalculateBonus;
        }
        public void CreateEmployee()
        {
            this._createEmployee.CreateEmployee();
        }

        public void CalculateEmployeeBonus()
        {
            this._calculateBonus.CalculateEmployeeBonus();
        }
    }
}
