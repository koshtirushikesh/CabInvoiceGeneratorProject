using System;

namespace CabInvoiceGeneraterProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InvoiceGenrater invoiceGenrater = new InvoiceGenrater();
            float fair = invoiceGenrater.CalculateFair(1, 2);
            Console.WriteLine("Fair: " + fair);

            fair = invoiceGenrater.CalculateFair(2, 4);
            Console.WriteLine("Fair: " + fair);

            Rides[] rides = { new Rides(1.0f, 2.0f), new Rides(2.0f, 4.0f) };

            InvoiceSummery invoice = invoiceGenrater.CalculateFair(rides);
            Console.WriteLine(invoice.NoOfRides);
            Console.WriteLine(invoice.TotalFair);
            Console.WriteLine(invoice.AverageFair);

            Console.ReadLine();
        }
    }
}
