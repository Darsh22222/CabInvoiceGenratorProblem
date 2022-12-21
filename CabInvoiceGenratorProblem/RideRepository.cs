using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenratorProblem
{
    public class RideRepository
    {
        private Dictionary<string, List<Ride>> userRideList = new Dictionary<string, List<Ride>>();
        public void AddCabRides(string userID, Ride[] ride)
        {
            bool checklist = this.userRideList.ContainsKey(userID);
            if (checklist == false)
            {
                this.userRideList.Add(userID, new List<Ride>(ride));
            }
        }
        public Ride[] GetCabRides(string userID)
        {
            return this.userRideList[userID].ToArray();
        }
    }
}
