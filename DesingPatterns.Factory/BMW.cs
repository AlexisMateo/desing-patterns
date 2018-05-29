using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.Factory
{
    public class BMW : IVehicle
    {
        public void TurnOff()
        {
            Console.WriteLine("BMW is Off");

        }

        public void TurnOn()
        {
            Console.WriteLine("BMW is On");
        }
    }
}
