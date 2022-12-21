using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenratorProblem
{
    public class CabInvoiceGenrator
    {
        private static readonly double COST_PER_KILOMETER = 10.0;
        private static readonly double COST_PER_MINUTE = 1.0;
        private static readonly double MININUM_FARE = 5.0;
        private double cabFare = 0.0;
        private RideRepository rideRepository = new RideRepository();


        public double CalculateFare(double distance, double time)
        {
            this.cabFare = (distance * COST_PER_KILOMETER) + (time * COST_PER_MINUTE);
            return Math.Max(this.cabFare, MININUM_FARE);
        }
        public InvoiceSummary GetMultipleRidersFare(Ride[] rides)
        {
            double totalRideFare = 0.0;
            foreach (Ride ride in rides)
            {
                totalRideFare += this.CalculateFare(ride.rideDistance, ride.rideTime);
            }
            return new InvoiceSummary(totalRideFare, rides.Length);
        }
        public void MapRidesToUser(string userID, Ride[] rides)
        {
            this.rideRepository.AddCabRides(userID, rides);
        }
        public InvoiceSummary GetInvoiceSummary(string userID)
        {
            return this.GetMultipleRidersFare(this.rideRepository.GetCabRides(userID));
        }
    }
}
