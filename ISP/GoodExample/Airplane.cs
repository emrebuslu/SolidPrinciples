using System;

namespace ISP.GoodExample
{
    public class Airplane : IVehicle, IFlyable, IEngine
    {
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
