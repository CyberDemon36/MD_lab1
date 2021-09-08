using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotsDistance_lab1;

namespace MD_lab1
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("1 - count the area of trapezoid \\n 2 - count the series #1 \\n 3 - count the series #2 and other function");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Select the lengths of the two heights and the angle of the base (a, b, alpha)");

                    double a = Convert.ToDouble(Console.ReadLine());
                    double b = Convert.ToDouble(Console.ReadLine());
                    double alpha = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Area : " + DllLib.areaOfTrapezoid(a, b, alpha));
                    break;
                case 2:
                    Console.WriteLine("Select the number of the end of the series :");

                    int n = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine( DllLib.sumOfTheSeries(n));
                    break;
                case 3:
                    Console.WriteLine("Select the the number of the end of the series and 'epsilon' variable :");

                    double num = Convert.ToDouble(Console.ReadLine());
                    double epsilon = Convert.ToDouble(Console.ReadLine());

                    DllLib.alternativeSumOfTheSeries(num, epsilon);
                    break;
                default:
                    Console.WriteLine("Error! The wrong option!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
