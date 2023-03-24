using System;
using System.Collections.Generic;

namespace CabInvoiceGeneraterProject
{
    public class InvoiceGenrater
    {
        RideRepository rideRepository = new RideRepository();
        readonly int COST_PER_KM = 10;
        readonly int COST_PER_MINIT = 1;

        public float CalculateFair(float distance, float time)
        {
            if (time == 0)
                throw new InvoiceGenraterException(InvoiceGenraterException.Type.INVALID_TIME, "Invalid Time");
            if (distance == 0)
                throw new InvoiceGenraterException(InvoiceGenraterException.Type.INVALID_DISTANCE, "Invalid Distance");

            float fair = distance * COST_PER_KM + time * COST_PER_MINIT;
            return Math.Max(5, fair);
        }

        public InvoiceSummery CalculateFair(Rides[] rides)
        {
            if (rides == null)
                throw new InvoiceGenraterException(InvoiceGenraterException.Type.NULL_RIDES, "Null Rides");

            float totalFair = 0;
            foreach (Rides ride in rides)
                totalFair = totalFair + CalculateFair(ride.Distance,ride.Time); 

            return new InvoiceSummery(rides.Length,totalFair);
        }
    }
}
