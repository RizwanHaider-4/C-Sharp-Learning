using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration2
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

  
    internal class Program
    {
        public void disp()

        {
            Console.WriteLine("<----Enumerations---->");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.disp();

            // 1

            DaysOfWeek birt = DaysOfWeek.Wednesday;
            Console.WriteLine(birt);
            
            // 2 enum to int
            Console.WriteLine((int)DaysOfWeek.Wednesday);

            // 3 interger to enum
            Console.WriteLine("Last day of week is " + (DaysOfWeek)6);

            // 4 enum to int 
            int x = Convert.ToInt32(DaysOfWeek.Sunday);
            Console.WriteLine("Sunday is on "+x+"th day of a week");

            // 5

        

        }
    }
}
