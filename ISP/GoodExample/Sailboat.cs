using System;

namespace ISP.GoodExample
{
    public class Sailboat : IVehicle, ISailable
    {
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
