using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  Program for calculation Fahrenheit ro Celsius
/// </summary>
namespace ConverseFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declearate variables
            float originalFahrenheit = 0;
            float celsius;
            float calculatedFahrenheit;
            bool correctValue = false;
            string enteredValue;

            // Reading value entered by user, parse value to float
            do
            {
                try
                {
                    Console.WriteLine("Enter teprature in Fahrenheit:");
                    enteredValue = Console.ReadLine();
                    if (enteredValue.Length == 0) throw new Exception();
                    originalFahrenheit = float.Parse(enteredValue);
                }
                catch (FormatException)
                {
                    correctValue = true;
                    Console.WriteLine("Entered value doesn't correct or press Enter for exit.");
                }
            } while (correctValue);

            // Calculate temperature in Celsius and Fahrenheit
            celsius = ((originalFahrenheit - 32) / 9) * 5;
            calculatedFahrenheit = (celsius / 5) * 9 + 32;

            // Display the teamperature in Celsius and Fahrenheit
            Console.WriteLine(originalFahrenheit+" degrees Fahrenheit is "+celsius+" degrees in Celsius");
            Console.WriteLine(celsius+" degrees in Celsius is "+calculatedFahrenheit+" degrees in Fahrenheit");
            Console.ReadKey();
        }
    }
}
