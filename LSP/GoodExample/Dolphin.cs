using System;

namespace LSP.GoodExample
{
    public class Dolphin : Swimmers
    {
        public override void Swim()
        {
            Console.WriteLine("Dolphin is swimming");
        }
        public void MakeShow()
        {
            Console.WriteLine("Dolphin is making show");
        }
    }
}
