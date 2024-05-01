using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Name");
            String name = Console.ReadLine();

            Console.WriteLine("Enter a Registration Number");
            String reg = Console.ReadLine();

            Console.WriteLine("Enter age");
            double age = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Blood Gropu");
            String bg = Console.ReadLine();

            Console.WriteLine("Favorite number");
            int fav = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Favourite Character");
            char fav_char = Char.Parse(Console.ReadLine());

            Console.WriteLine("/----Details-----/");
            Console.WriteLine("Name is               :"+name);
            Console.WriteLine("Registration number   :"+reg);
            Console.WriteLine("Age is                :"+age);
            Console.WriteLine("Blood Group is        :"+bg);
            Console.WriteLine("Favourite Number      :"+fav);
            Console.WriteLine("Favourite Character   :"+fav_char);




        }
    }
}
