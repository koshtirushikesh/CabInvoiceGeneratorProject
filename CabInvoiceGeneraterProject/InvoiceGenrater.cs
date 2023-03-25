using System;

namespace CabInvoiceGeneraterProject
{
    public class InvoiceGenrater
    {
        readonly int COST_PER_KM = 10;
        readonly int COST_PER_MINIT = 1;
        readonly int MINIMUM_FAIR = 5;

        public InvoiceGenrater()
        {

        }

        public InvoiceGenrater(RideType rideType)
        {
            try
            {
                if (rideType.Equals(RideType.NORMAL))
                {
                    this.COST_PER_KM = 10;
                    this.COST_PER_MINIT = 1;
                    this.MINIMUM_FAIR = 5;
                }
                if (rideType.Equals(RideType.PRIMEMUM))
                {
                    this.COST_PER_KM = 15;
                    this.COST_PER_MINIT = 2;
                    this.MINIMUM_FAIR = 20;
                }
            }
            catch(InvoiceGenraterException)
            {
                throw new InvoiceGenraterException(InvoiceGenraterException.Type.INVALID_RIDE_TYPE,"Invalid Ride Type Select Normal or Premium");
            }
        }

        public float CalculateFair(float distance, float time)
        {
            if (time == 0)
                throw new InvoiceGenraterException(InvoiceGenraterException.Type.INVALID_TIME, "Invalid Time");
            if (distance == 0)
                throw new InvoiceGenraterException(InvoiceGenraterException.Type.INVALID_DISTANCE, "Invalid Distance");

            float fair = distance * COST_PER_KM + time * COST_PER_MINIT;
            return Math.Max(MINIMUM_FAIR, fair);
        }

        public InvoiceSummery CalculateFair(Rides[] rides)
        {
            if (rides == null)
                throw new InvoiceGenraterException(InvoiceGenraterException.Type.NULL_RIDES, "Null Rides");

            float totalFair = 0;
            foreach (Rides ride in rides)
                totalFair = totalFair + CalculateFair(ride.Distance, ride.Time);

            return new InvoiceSummery(rides.Length, totalFair);
        }
    }
}
