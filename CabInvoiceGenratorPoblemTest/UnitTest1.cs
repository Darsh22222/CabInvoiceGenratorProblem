using CabInvoiceGenratorProblem;
using System;

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
    }
}