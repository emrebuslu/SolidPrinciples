using System;

namespace LSP.GoodExample
{
    public class Frog : Amphibians
    {
        public override void Walk()
        {
            Console.WriteLine("Frog is walking");
        }
        public override void Swim()
        {
            Console.WriteLine("Frog is swimming");
        }
        public void Hunt()
        {
            Console.WriteLine("Frog is hunting");
        }
    }
}
