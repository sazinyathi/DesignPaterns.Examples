using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns.StrategyPattern
{
    public class CalculateBonus : ICalculateBonus
    {
        public void CalculateEmployeeBonus()
        {
            Console.WriteLine("CalculateEmployeeBonus");
        }
    }
}
