using System;

namespace ISP.PoorExample
{
    public class Airplane : IVehicle
    {

        /* <<< Interface Segregation Principle VIOLATE */
        public void Sail()
        {
            Console.WriteLine("Airplanes can not sail");
        }
        /* Interface Segregation Principle VIOLATE >>> */

        public void Fly()
        {
            Console.WriteLine("Airplane is flying");
        }
        public void Model()
        {
            Console.WriteLine("Airplane's model is DWM");
        }
        public void Start()
        {
            Console.WriteLine("Airplane's engine is started");
        }
        public void Stop()
        {
            Console.WriteLine("Airplane's engine is stoped");
        }
        public void Color()
        {
            Console.WriteLine("Airplane's color is yellow");
        }
    }
}
