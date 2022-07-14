using System;

namespace LSP.GoodExample
{
    public class Swimmers : ISwimmer
    {
        public virtual void Swim()
        {
            Console.WriteLine("Swimmers can swim");
        }
    }
}
