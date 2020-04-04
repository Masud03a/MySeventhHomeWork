
using System;

namespace Task_1
{
    class Rectangle
    {
        private double side1;
        private double side2;
        public double square { 
            get 
            {
                return SquareCounter(); 
            }
        }
        public double Periphery { 
            get 
            {
                return PeripheryCounter(); 
            }
        }
        public Rectangle(double Side1, double Side2)
        {
            this.side1 = Side1;
            this.side2 = Side2;
        }

        private double SquareCounter()
        {           
            return this.side1 * this.side2;
        }

        private double PeripheryCounter()
        {           
            return 2 * (this.side1 + this.side2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine().Replace(".", ","));
            double B = double.Parse(Console.ReadLine().Replace(".", ","));

            Rectangle rect = new Rectangle(A, B);
            Console.WriteLine("SQUARE: " + rect.square);
            Console.WriteLine("PERIPHERY: " + rect.Periphery);
        }
    }
}
