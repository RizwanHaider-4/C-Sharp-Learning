using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    internal class Program
    {
        enum DaysOfWeek
            { 
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }

        static void Main(string[] args)
        {
            // 1
            DaysOfWeek birthday = DaysOfWeek.Wednesday;

            // DaysOfWeek --> enum
            // birthday --> enum Variable


            // 1 
            // Explicit Converion
            // enum to values

            int x = Convert.ToInt32(DaysOfWeek.Monday);  

            // 2 enum to values

            int y = (int)DaysOfWeek.Sunday;


            // 1. b
            Console.WriteLine(Convert.ToInt32(DaysOfWeek.Thursday));

            // 2 b
            Console.WriteLine((int)DaysOfWeek.Friday);

            // 1.  values to enums
            // explicit converion

            DaysOfWeek day = (DaysOfWeek)3; // Explicit

            Console.WriteLine(day);

            // if enum member 3 not present then it will print 3

        }
    }
}
