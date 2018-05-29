using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.Factory
{
    public class Lamborgini : IVehicle
    {
        public void TurnOff()
        {
            Console.WriteLine("Lamborgini is Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Lamborgini is On");
        }
    }
}
