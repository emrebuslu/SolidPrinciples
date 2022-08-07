using System;

namespace LSP.GoodExample
{
    public class Amphibians
    {
        public virtual void Walk()
        {
            Console.WriteLine("Amphibians can walk");
        }
        public virtual void Swim()
        {
            Console.WriteLine("Amphibians can swim");
        }
    }
}
