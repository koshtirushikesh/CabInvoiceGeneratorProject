using System;

namespace CabInvoiceGeneraterProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InvoiceGenrater invoiceGenrater = new InvoiceGenrater();
            float fair = invoiceGenrater.CalculateFair(0, 1);
            Console.WriteLine("Fair: " + fair);
            Console.ReadLine();
        }
    }
}
