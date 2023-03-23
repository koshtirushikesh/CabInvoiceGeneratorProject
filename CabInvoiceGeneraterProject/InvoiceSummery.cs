using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneraterProject
{
    public class InvoiceSummery
    {
        public int NoOfRides;
        public float TotalFair;
        public float AverageFair;

        public InvoiceSummery(int noOfRids,float totalFair)
        {
            NoOfRides = noOfRids;
            TotalFair = totalFair;
            AverageFair = totalFair/noOfRids;
        }
    }
}
