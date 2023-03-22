using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneraterProject
{
    public class InvoiceGenraterException: Exception
    {
        public enum Type
        {
            INVALID_DISTANCE,
            INVALID_TIME,
        }
        Type type;
        public InvoiceGenraterException(Type type , string message):base(message)
        {
            this.type = type;  
        }
    }
}
