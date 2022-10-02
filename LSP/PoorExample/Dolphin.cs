using System;

namespace LSP.PoorExample
{
    public class Dolphin : Amphibians
    {
        public override void Swim()
        {
            Console.WriteLine("Dolphin is swimming");
        }
        public void MakeShow()
        {
            Console.WriteLine("Dolphin is making show");
        }

        /* <<< Liskov Substitution Principle VIOLATE */
        public override void Walk()
        {
            Console.WriteLine("Dolphins can not walk");
        }
        /* Liskov Substitution Principle VIOLATE >>> */

    }
}
