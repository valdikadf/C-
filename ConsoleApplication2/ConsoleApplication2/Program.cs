using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            double[] root =quadratic(1, 3, 2);
            Console.WriteLine(root[0]);
            Console.ReadKey(); 
        }

        public static double[] quadratic(int a,int b,int c)
        {
            double[] result = new double[2];
            if (a != 0)
            {
                double d = b * b - 4 * a * c;
                if (d > 0)
                {
                    result[0] = (-b + Math.Sqrt(d)) / 2 * a;
                    result[1] = (-b - Math.Sqrt(d)) / 2 * a;
                    return result;
                }
            }
            else
            {
                result[0] = -c / b;
            }
            return result;
        }
    }
}