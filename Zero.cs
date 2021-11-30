using System;

namespace Garage
{
    public class Zero  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
         public void Drive()
        {
            Console.WriteLine("The black Zero Rooom!");
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
