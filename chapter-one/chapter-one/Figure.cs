using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_one
{
    public class Figure:TestInterface 
    {
        private double A;
        private double B;
        private double C;
        private double Squere;
        private double Perimetr;

        public Figure()
        {
            A = 0;
            B = 0;
            C = 0;
            Squere = 0;
            Perimetr = 0;
        }

        public Figure(double a)
        {
            A = a;
        }
        public double CulculatePerimetr()
        {
            return this.A * 4;
        }

        public double CalculateSquere()
        {
            return this.A*this.A;
        }

        public int FeetToInches(int a)
        {
            return a * 12;
        }

        public double PerimetrRectangle(double a, double b)
        {
            return 2 * (a + b);
        }
        public double SqureRectangele(double a, double b)
        {
            return a * b;
        }
    }
}
