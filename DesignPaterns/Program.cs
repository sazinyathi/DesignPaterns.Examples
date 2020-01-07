using DesignPaterns.DecoratorPattern;
using DesignPaterns.DecoratorPattern.Models.Cups;
using DesignPaterns.ObserverPattern.Service;
using DesignPaterns.StrategyPattern;
using System;

namespace DesignPaterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallCup = new Cups { CupsSize = (int)CupsSize.smallCupSize };
            var meduimCup = new Cups { CupsSize = (int)CupsSize.mediumCupSize };
            var decoratorPatternService = new DecoratorPattenService();
            var expressWithDoubleShortSmallCup = decoratorPatternService.ExpressWithDoubleShort(smallCup);
            Console.WriteLine("Cost of ExpressWithDoubleShortSmallCup {0}", expressWithDoubleShortSmallCup);

            var expressWithDoubleShortLargeCup = decoratorPatternService.ExpressWithDoubleShort(meduimCup, (int)CupsSize.mediumCupSize);
            Console.WriteLine("Cost of ExpressWithDoubleMeduimCup {0}", expressWithDoubleShortLargeCup);

            var expressWithCaramelSmallCup = decoratorPatternService.ExpressWithCaramel(smallCup);
            Console.WriteLine("Cost of ExpressWithCaramelSmallCup {0}", expressWithCaramelSmallCup);

            var expressWithCaramelMeduimCup = decoratorPatternService.ExpressWithCaramel(meduimCup,(int)CupsSize.mediumCupSize);
            Console.WriteLine("Cost of ExpressWithCaramelMeduimCup {0}", expressWithCaramelMeduimCup);

            var expressWithCaramelAndDoubleShortSmallCup = decoratorPatternService.ExpressWithCaramelAndDoubleShort(smallCup);
            Console.WriteLine("Cost of ExpressWithCaramelAndDoubleShortSmallCup {0}", expressWithCaramelAndDoubleShortSmallCup);

            var expressWithCaramelAndDoubleShortMeduimCup = decoratorPatternService.ExpressWithCaramelAndDoubleShort(meduimCup,(int)CupsSize.mediumCupSize);
            Console.WriteLine("Cost of ExpressWithCaramelAndDoubleShortMeduimCup {0}", expressWithCaramelAndDoubleShortMeduimCup);

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

        public enum CupsSize
        {
            smallCupSize = 1,
            mediumCupSize = 2,
            largeCupSize = 3,
            extraLargeCupSize = 4
        }
    }

}
