using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args) 
        {
            PoorExample();
            //GoodExample();
            Console.ReadKey();
        }

        static void PoorExample()
        {
            PoorExample.Calculator calculator = new PoorExample.Calculator();
            
            PoorExample.Circle circle = new PoorExample.Circle();
            circle.RadiusWidth = 10;

            PoorExample.Square square = new PoorExample.Square();
            square.EdgeWidth = 10;

            double squareArea = calculator.Area(square);
            double circleArea = calculator.Area(circle);

            Console.WriteLine("Area of my square is : {0}", squareArea);
            Console.WriteLine("Area of my circle is : {0}", circleArea);
        }

        static void GoodExample()
        {
            GoodExample.Calculator calculator = new GoodExample.Calculator();

            GoodExample.Circle circle = new GoodExample.Circle();
            circle.RadiusWidth = 10;

            GoodExample.Square square = new GoodExample.Square();
            square.EdgeWidth = 10;

            double squareArea = calculator.Area(square);
            double circleArea = calculator.Area(circle);

            Console.WriteLine("Area of my square is : {0}", squareArea);
            Console.WriteLine("Area of my circle is : {0}", circleArea);
        }

    }
}
