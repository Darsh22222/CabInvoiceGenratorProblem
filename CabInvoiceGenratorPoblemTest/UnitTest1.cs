using CabInvoiceGenratorProblem;
using System;
using static CabInvoiceGenratorProblem.RideOption;

namespace CabInvoiceGenratorProblem
{
    public class CabInvoiceGenratorProblemTest
    {
        private CabInvoiceGenrator cabInvoiceGenrator;
        [SetUp]
        public void Setup() //For creating instance of class
        {
            this.cabInvoiceGenrator = new CabInvoiceGenrator();
        }

        [Test]
        //Test to get total fare using given time and distance
        public void GivenProperDistanceAndTimeForSingleRide_ShouldReturnTotalFare()
        {
            double totalFare = cabInvoiceGenrator.CalculateFare(3.0, 5.0);
            Assert.AreEqual(35.0, totalFare);
        }
        [Test]
        //Test to get Mininum Fare when given less than minimum fare
        public void GivenProperDistanceAndTimeForSingleRide_LessThanMinFare_ShouldReturnMinimumFare()
        {
            double CabFare = cabInvoiceGenrator.CalculateFare(0.1, 0.5);
            Assert.AreEqual(5, CabFare);
        }
        [Test]
        //Test to get aggregate fare for multiple rides
        public void GivenProperDistanceAndTimeForMultipleRide_ShouldReturnAggregateFare()
        {
            Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0), new Ride(0.1, 0.5) };
            InvoiceSummary invoiceSummary = this.cabInvoiceGenrator.GetMultipleRidersFare(ride);
            Assert.AreEqual(65, invoiceSummary.totalFare);
        }
        [Test]
        //Test to get invoice summary for userID
        public void GivenProperDistanceAndTimeForRide_ShouldReturnFare()
        {
            CabInvoiceGenrator generator = new CabInvoiceGenrator();
            Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0) };
            generator.MapRidesToUser("Darshan", ride);
            InvoiceSummary summary = generator.GetInvoiceSummary("Darshan");
            Assert.AreEqual(summary.totalFare, 60.0);
        }
        [Test]
        //Test to get fare for premium rides
        public void GivenProperDistanceAndTimeForPremiumeRide_ShouldReturnPremiumFare()
        {
            try
            {
                double distance = -5; //in km
                int time = 20;   //in minute
                CabInvoiceGenrator summary = new CabInvoiceGenrator(RideType.NORMAL);
                double fare = summary.CalculateFare(distance, time);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Invalid Ride Type");
            }
        }
    }
}