using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// Application for find and angle distance between points.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method for ap
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Exsplained message
            Console.WriteLine("This program calculate the distans and angle between two points.");

            // Declarete the variables and invite message
            Console.Write("Point 1 X:");
            float pointX1 = float.Parse(Console.ReadLine());
            Console.Write("Point 1 Y:");
            float pointY1 = float.Parse(Console.ReadLine());
            Console.Write("Point 2 X:");
            float pointX2 = float.Parse(Console.ReadLine());
            Console.Write("Point 2 Y:");
            float pointY2 = float.Parse(Console.ReadLine());

            //  Calculate the distance and angle between points
            Console.WriteLine("Distance between points: " +  Math.Sqrt((pointX1 - pointX2)* (pointX1 - pointX2) + (pointY1 - pointY2)* (pointY1 - pointY2)));
            Console.WriteLine("Angle between points:" + Math.Atan2(pointX2 - pointX1, pointY2 - pointY1) * 180 / Math.PI);
            Console.ReadKey();
        }
    }
}