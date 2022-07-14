using System;

namespace LSP
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
            PoorExample.Amphibians frog = new PoorExample.Frog();
            frog.Walk();
            frog.Swim();

            PoorExample.Amphibians dolphin = new PoorExample.Dolphin();
            dolphin.Swim();
            dolphin.Walk();//poor method
        }

        static void GoodExample()
        {
            GoodExample.Amphibians frog = new GoodExample.Frog();
            frog.Walk();
            frog.Swim();

            GoodExample.Swimmers dolphin = new GoodExample.Dolphin();
            dolphin.Swim();
        }
    }
}
