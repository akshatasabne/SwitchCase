using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Days
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter your choice");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Monday");
            Console.WriteLine("2.Tuesday");
            Console.WriteLine("3.Wednesday");
            Console.WriteLine("4.Thursday");
            Console.WriteLine("5.Friday");
            Console.WriteLine("6.Saturday");
            Console.WriteLine("7.Sunday");
            Console.WriteLine("Select your chioce");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Day is Monday");
                    break;
                case 2:
                    Console.WriteLine("Day is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Day is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Day is Thursday");
                    break; ;
                case 5:
                    Console.WriteLine("Day is Friday");
                    break;
                case 6:
                    Console.WriteLine("Day is Saturday");
                    break;  
                case 7:
                    Console.WriteLine("Day is Sunday");
                break;

            }
        }
    }
}
