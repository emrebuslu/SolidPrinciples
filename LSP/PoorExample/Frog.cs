using System;

namespace LSP.PoorExample
{
    public class Frog : Amphibians
    {
        public override void Swim()
        {
            Console.WriteLine("Frog is swimming");
        }
        public override void Walk()
        {
            Console.WriteLine("Frog is walking");
        }
        public void Hunt()
        {
            Console.WriteLine("Frog is hunting");
        }
    }
}
