using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenratorProblem
{
    public class RideOption
    {
        public enum RideType
        {
            NORMAL,
            PREMIUM,
        }
        public double costPerKms;
        public double costPerMinute;
        public double minimumFare;
        public RideOption(double costPerKms, double costPerMinute, double minimumFare)
        {
            this.costPerKms = costPerKms;
            this.costPerMinute = costPerMinute;
            this.minimumFare = minimumFare;
        }
        public RideOption()
        {
        }
        public RideOption SetRideValue(RideType rideType)
        {
            switch (rideType)
            {
                case RideType.NORMAL:
                    return new RideOption(10.0, 1.0, 5.0);
                case RideType.PREMIUM:
                    return new RideOption(15.0, 2.0, 20.0);
                default:
                    return null;
            }
        }
    }
}
