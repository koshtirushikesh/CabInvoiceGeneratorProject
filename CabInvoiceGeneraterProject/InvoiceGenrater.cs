using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneraterProject
{
    public class InvoiceGenrater
    {
        readonly int PER_KM = 10;
        readonly int PER_MINIT = 1;

        public float CalculateFair(float distance, float time)
        {
            if (time == 0)
                throw new InvoiceGenraterException(InvoiceGenraterException.Type.INVALID_TIME, "Invalid Time");
            if (distance == 0)
                throw new InvoiceGenraterException(InvoiceGenraterException.Type.INVALID_DISTANCE, "Invalid Distance");

            float fair = distance * PER_KM + time * PER_MINIT;
            return Math.Max(5,fair);
        }
    }
}
