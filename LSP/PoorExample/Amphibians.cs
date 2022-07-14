using System;

namespace LSP.PoorExample
{
    public class Amphibians
    {
        public virtual void Walk()
        {
            Console.WriteLine("Walking");
        }
        public virtual void Swim()
        {
            Console.WriteLine("Swimming");
        }
    }
}
