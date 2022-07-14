using System;

namespace OCP.GoodExample
{
    public class Circle : Shape
    {
        public int RadiusWidth { get; set; }

        public override double Area()
        {
            return RadiusWidth * RadiusWidth * Math.PI;
        }
    }
}
