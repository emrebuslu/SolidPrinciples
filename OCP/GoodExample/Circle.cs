using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
