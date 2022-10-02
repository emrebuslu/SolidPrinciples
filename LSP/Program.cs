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
            PoorExample.Frog frog = new PoorExample.Frog();
            frog.Walk();
            frog.Swim();
            frog.Hunt();

            PoorExample.Dolphin dolphin = new PoorExample.Dolphin();
            dolphin.Swim();
            dolphin.Walk();//poor method
            dolphin.MakeShow();
        }

        static void GoodExample()
        {
            GoodExample.Frog frog = new GoodExample.Frog();
            frog.Walk();
            frog.Swim();
            frog.Hunt();

            GoodExample.Dolphin dolphin = new GoodExample.Dolphin();
            dolphin.Swim();
            dolphin.MakeShow();
        }
    }
}
