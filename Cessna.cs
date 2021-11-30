using System;

namespace Garage
{
    public class Cessna  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
         public void Drive()
        {
            Console.WriteLine("The blue Cessna goes ......");
        }
             public void Turn()
        {
            Console.WriteLine("The black Zero Turns slowly");
        }
         public void Stop()
        {
            Console.WriteLine("The black Zero screeches to a stop");
        }
    }
}
