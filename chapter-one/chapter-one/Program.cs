using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_one
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the length of the side squere.");
            //double b = 0,a = 0;
            //bool rightFormat;
            //do
            //{
            //    try
            //    {
            //        Console.Write("a = ");
            //        a = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
            //        Console.Write("b = ");
            //        b = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
            //        rightFormat = false;
            //    }
            //    catch (FormatException)
            //    {
            //        rightFormat = true;
            //        Console.WriteLine("Exception: the format of entered is not right");
            //    }
            //} while (rightFormat);
            //Console.WriteLine("The perimetr of squere equal to " + Perimetr(b));
            //Console.WriteLine("The squere is equal to " + Squere(b));
            //Console.WriteLine(FeetToInches(10));
            //Console.WriteLine("The rectangle perimetr equal to " + PerimetrRectangle(a,b)
            //                    + " and the squere is " + SquereRectangle(a, b) );

            //UnitConvertor feetToIchesConvetor = new UnitConvertor(12);
            //UnitConvertor maelToFeetConvector = new UnitConvertor(5820);
            //Figure sqere = new Figure(3);
            //Console.WriteLine(sqere.CalculateSquere());
            //Console.WriteLine("The type of 1 is " + i.GetType());
            //Console.WriteLine("The method is " + DeleteWhiteSpaces("a  =   1 b = 1").Equals("a=1 b=1", StringComparison.Ordinal) + DeleteWhiteSpaces("a  = 1"));
            //Console.WriteLine(DeleteWhiteSpaces("a = 1 b =   3"));
            Console.WriteLine();
            List<string[]> variables = Interpretator("  a=10 b=39 c=42 ");
            Console.ReadKey();

            // Declear variable 
            const int MaxStore = 100;
            int score = 32;
            float persent = (float)score / MaxStore;

            // Printing calculated persent
            Console.WriteLine("Persent of score is " + persent);
        }
        
        public static List<string[]> Interpretator(string line)
        {
            line = line.Trim();
            //line = DeleteWhiteSpaces(line);          
            string[] substring = line.Split(' ');
            List<string[]> words = new  List<string[]>();
            foreach (string word in substring)
            {
                words.Add(word.Split('='));
            }
            foreach (string[] word in words)
            {
                foreach (string text in word)
                {
                    Console.WriteLine("Splited text: " + text);
                }
            }
            return words;
        }
        
        public static string DelWhiSpac(string line)
        {
            for (int i = 0; i < line.Length;i++)  if (line[i] == ' ' && line[i + 1] == ' ') line.Remove(i, 1); 
            return line;
        }

        public static string DeleteWhiteSpaces(string line)
        {
            int endIx = 0;
            for (; endIx < line.Length; endIx++) { if (line[endIx] == '=') break; }
            for (int i = 0; i < endIx; i++)
            {
                if (line[i] == ' ' && line[i + 1] != ' ' && line[i + 1] != '=') throw new Exception(""+i);
                if (line[i] == ' ') { line = line.Remove(i, 1); i--;endIx--; }

                }
            int strIx = endIx;
            for (; endIx < line.Length; endIx++)
            {
                if (line[endIx] == ' ' && line[endIx + 1] != ' ')line = line.Remove(strIx+1, endIx - strIx);
            }
            strIx = endIx;
            for(; strIx < line.Length; strIx++)
            {
                if (line[strIx] != ' ') break;
            }
            endIx = strIx;
            for (; endIx < line.Length; endIx++) { if (line[endIx] == '=') break; }
            for (int i = 0; i < endIx; i++)
            {
                if (line[i] == ' ' && line[i + 1] != ' ' && line[i + 1] != '=') throw new Exception("" + i);
                if (line[i] == ' ') { line = line.Remove(i, 1); i--; endIx--; }

            }
            strIx = endIx;
            for (; endIx < line.Length; endIx++)
            {
                if (line[endIx] == ' ' && line[endIx + 1] != ' ') line = line.Remove(strIx + 1, endIx - strIx);
                if (line[endIx] == ' ' && line[endIx - 1] != ' ') break;
            }
            return line;
        }                     
    }
        
}
