using System;

namespace ISP.PoorExample
{
    public class Car : IVehicle
    {

        /* <<< Interface Segregation Principle VIOLATE */
        public void Fly()
        {
            Console.WriteLine("Cars can not fly");
        }
        public void Sail()
        {
            Console.WriteLine("Cars can not sail");
        }
        /* Interface Segregation Principle VIOLATE >>> */

        public void Model()
        {
            Console.WriteLine("Car's model is DWM");
        }

        public void Start()
        {
            Console.WriteLine("Car's engine is started");
        }

        public void Stop()
        {
            Console.WriteLine("Car's engine is stoped");
        }
        public void Color()
        {
            Console.WriteLine("Car's color is darkblue");
        }
    }
}
