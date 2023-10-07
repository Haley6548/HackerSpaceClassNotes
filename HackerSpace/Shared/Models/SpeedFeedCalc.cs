using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerSpace.Shared.Modles
{
    public class SpeedFeedCalc
    {
        private double chipLoad;

        public double ChipLoad
        {
            get { return chipLoad; }
            set 
            { 
              if (value < 0)
              {
                    throw new Exception("Chip load must be positive.");  
              }
                chipLoad = value; Calc(); 
            }
        }
        private double rpm;

        public double RPM
        {
            get { return rpm; }
            set { rpm = value; Calc(); }
        }
        private double flutes;

        public double Flutes
        {
            get { return flutes; }
            set { flutes = value; Calc(); }
        }
        public double FeedRate { get; private set; }

        private void Calc()
        {
            FeedRate = chipLoad * rpm * flutes;
        }
    }
}
