using DesignPaterns.DecoratorPattern;
using DesignPaterns.ObserverPattern.Service;
using DesignPaterns.StrategyPattern;
using System;

namespace DesignPaterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var decoratorPatternService = new DecoratorPattenService();
            var expressWithDoubleShort = decoratorPatternService.ExpressWithDoubleShort();
            Console.WriteLine("Cost of ExpressWithDoubleShort {0}",expressWithDoubleShort);

            var expressWithCaramel = decoratorPatternService.ExpressWithCaramel();
            Console.WriteLine("Cost of ExpressWithCaramel {0}", expressWithCaramel);

            var expressWithCaramelAndDoubleShort = decoratorPatternService.ExpressWithCaramelAndDoubleShort();
            Console.WriteLine("Cost of ExpressWithCaramelAndDoubleShort {0}", expressWithCaramelAndDoubleShort);

            var oberserPatternService = new ObseverPatternService();
            for(int i = 1; i < 5; i ++)
            {
                oberserPatternService.Execute(i);
            }
            
            var employee = new Employee();
            employee.CreateEmployee();
            employee.CalculateEmployeeBonus();
           


            Console.ReadLine();
        }
    }
}
