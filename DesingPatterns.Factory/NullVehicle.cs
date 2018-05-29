using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.Factory
{
    public class NullVehicle : IVehicle
    {
        public void TurnOff()
        {
            Console.WriteLine("There's no vehicles to Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("There's no vehicles to Turn On");
        }
    }
}
