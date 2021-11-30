using System;

namespace Garage
{
    public class Tesla  // Electric car
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
            Console.WriteLine("The White Tesla goes ......");
        }
            public void Turn()
        {
            Console.WriteLine("The Vehicle Turns slowly");
        }
         public void Stop()
        {
            Console.WriteLine("The Vehicle screeches to a stop");
        }
    }
}
