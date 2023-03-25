using System;
using System.Collections.Generic;

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

            RideRepository rideRepository = new RideRepository();
            rideRepository.AddRides("RushiKoshti", rides);

            List<Rides> listOfRides = rideRepository.GetRides(userId: "RushiKoshti");

            foreach (var ride in listOfRides)
            {
                Console.WriteLine(ride.Distance + "\n" + ride.Time);
            }

            InvoiceSummery invoice = invoiceGenrater.CalculateFair(listOfRides.ToArray());
            Console.WriteLine("\nNO Of Rides " + invoice.NoOfRides +
                              "\nTotalFair " + invoice.TotalFair +
                              "\nAvgFair " + invoice.AverageFair);

            InvoiceGenrater invoiceGenrater1 = new InvoiceGenrater(RideType.NORMAL);
            float fair1 = invoiceGenrater1.CalculateFair(1, 2);
            Console.WriteLine("Fair: " + fair1);

            InvoiceGenrater invoiceGenrater2 = new InvoiceGenrater(RideType.PRIMEMUM);
            float fair2 = invoiceGenrater2.CalculateFair(1, 2);
            Console.WriteLine("Fair: " + fair2);

            Console.ReadLine();
        }
    }
}
