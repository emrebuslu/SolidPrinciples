using System;

namespace OCP.PoorExample
{
    public class Calculator
    {
        double calculatedArea = 0;
        public double Area(object shape)
        {

            /* <<< Open/Closed Principle VIOLATE */
            if (shape is Circle circle)
            {
                calculatedArea = circle.RadiusWidth * circle.RadiusWidth * Math.PI;
            }
            else if (shape is Square square)
            {
                calculatedArea = square.EdgeWidth * square.EdgeWidth;
            }
            /* Open/Closed Principle VIOLATE >>> */

            return calculatedArea;
        }
    }
}
