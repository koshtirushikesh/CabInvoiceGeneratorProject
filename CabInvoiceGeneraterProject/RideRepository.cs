using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneraterProject
{
    public class RideRepository
    {
        private Dictionary<string, List<Rides>> userRideDictonary = new Dictionary<string, List<Rides>>();
        public void AddRides(string userId , Rides[] rides)
        {
            if (rides == null)
                throw new InvoiceGenraterException(InvoiceGenraterException.Type.NULL_RIDES,"Null Rides");

            if(userRideDictonary.ContainsKey(userId))
            {
                userRideDictonary[userId].AddRange(rides);
            }
            else
            {
                userRideDictonary.Add(userId,new List<Rides>());
                userRideDictonary[userId].AddRange(rides);
            }
        }

        public List<Rides> GetRides(string userId)
        {
            if(!userRideDictonary.ContainsKey(userId))
                throw new InvoiceGenraterException(InvoiceGenraterException.Type.INVALID_USERID, "Invalid User ID");

            return userRideDictonary[userId];
        }
    }
}
