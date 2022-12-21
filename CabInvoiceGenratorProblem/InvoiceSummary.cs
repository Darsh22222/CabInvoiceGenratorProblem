using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenratorProblem
{
    public class InvoiceSummary
    {

        public double totalFare;
        public double averageFare;
        public double noOfRides;
        public InvoiceSummary(double totalFare, int noOfRides)
        {
            this.totalFare = totalFare;
            this.noOfRides = noOfRides;
            this.averageFare = this.totalFare / this.noOfRides;
        }
    }
}
