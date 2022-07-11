using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.GoodExample
{
    public class Square : Shape
    {
        public int EdgeWidth { get; set; }

        public override double Area()
        {
            return EdgeWidth * EdgeWidth;
        }
    }
}
