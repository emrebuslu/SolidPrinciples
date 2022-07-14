using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            PoorExample();
            //GoodExample();
            Console.ReadKey();
        }
        static void PoorExample()
        {
            PoorExample.Airplane airplane = new PoorExample.Airplane();
            airplane.Start();
            airplane.Model();
            airplane.Color();
            airplane.Sail();//poor method
            airplane.Fly();
            airplane.Stop();

            PoorExample.Car car = new PoorExample.Car();
            car.Start();
            car.Model();
            car.Color();
            car.Sail();//poor method
            car.Fly(); //poor method
            car.Stop();

            PoorExample.Sailboat sailboat = new PoorExample.Sailboat();
            sailboat.Start();//poor method
            sailboat.Model();
            sailboat.Color();
            sailboat.Sail();
            sailboat.Fly(); //poor method
            sailboat.Stop();//poor method
        }

        static void GoodExample()
        {
            GoodExample.Airplane airplane = new GoodExample.Airplane();
            airplane.Start();
            airplane.Model();
            airplane.Color();
            airplane.Fly();
            airplane.Stop();

            GoodExample.Car car = new GoodExample.Car();
            car.Start();
            car.Model();
            car.Color();
            car.Stop();

            GoodExample.Sailboat sailboat = new GoodExample.Sailboat();
            sailboat.Model();
            sailboat.Color();
            sailboat.Sail();
        }
    }
}
