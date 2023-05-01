using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leapyear
{
    internal class Leapyear
    {
        public static void Displayleapyear()
        {
            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine()); 
            if(year >1000 && year <9999)
            {
                if (year % 4 ==0 && (year % 100 != 0 || year % 400 ==0))
                {
                    Console.WriteLine("the {0} is a leap year", year);
                }
                else
                {
                    Console.WriteLine("the {0} is not a leap year", year);
                }
            }
        }
    }
}
