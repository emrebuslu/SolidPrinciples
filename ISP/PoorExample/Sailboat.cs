using System;

namespace ISP.PoorExample
{
    public class Sailboat : IVehicle
    {

        /* <<< Interface Segregation Principle VIOLATE */
        public void Start()
        {
            Console.WriteLine("Sailboat has no engine");
        }
        public void Fly()
        {
            Console.WriteLine("Sailboat can not flying");
        }
        public void Stop()
        {
            Console.WriteLine("Sailboat has no engine");
        }
        /* Interface Segregation Principle VIOLATE >>> */

        public void Model()
        {
            Console.WriteLine("Sailboat model is DWM");
        }
        public void Color()
        {
            Console.WriteLine("Sailboat color is black");
        }
        public void Sail()
        {
            Console.WriteLine("Sailboat set sail");
        }
    }
}
