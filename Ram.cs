using System;

namespace Garage
{
    public class Ram  // Gas powered truck
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
            Console.WriteLine("I have a tiny blue wiener!");
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
