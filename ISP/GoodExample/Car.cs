using System;

namespace ISP.GoodExample
{
    public class Car : IVehicle, IEngine
    {
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
