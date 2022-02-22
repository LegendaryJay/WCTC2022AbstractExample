using System;

namespace AbstractExample.Models
{
    public class Duxk : Animal
    {
        //definitely not a typo
        public override void MakeNoise()
        {
            Console.WriteLine("quaxk");
        }

        public override void Sleep()
        {
            Console.WriteLine("Bzzzzzz");
        }
    }
}