using CabInvoiceGeneraterProject;

namespace CabInvoiceGeneraterTestCase
{
    public class InvoiceGeneraterTestCase
    {
        InvoiceGenrater invoiceGenrater = new InvoiceGenrater();
        [Test]
        public void GivenZeroValue_ShouldReturnCustomException()
        {
            try
            {
                float fair = invoiceGenrater.CalculateFair(1, 0);
            }
            catch(Exception ex)
            {
                Assert.AreEqual("Invalid Time", ex.Message);
            }
        }

        [Test]
        public void GivenDistnceAndTime_ShouldReturnFair()
        {
            Assert.AreEqual(11,invoiceGenrater.CalculateFair(1,1));
        }

        [Test]
        public void GivenMinDistnceAndMinTime_ShouldReturnDefaultFair()
        {
            Assert.AreEqual(5, invoiceGenrater.CalculateFair(0.1f,0.1f));
        }

        [Test]
        public void GivenSetOfRides_ShouldReturnTotalFair()
        {
            Rides[] rides = { new Rides(1.0f, 2.0f), new Rides(2.0f, 4.0f) };

            float totalFair = invoiceGenrater.CalculateFair(rides);
            Assert.AreEqual(36,totalFair);
        }

        [Test]
        public void GivenNullRides_ShouldReturnNullRideException()
        {
            Rides[] rides = null;
            try
            {
                float totalFair = invoiceGenrater.CalculateFair(rides);
            }
            catch(InvoiceGenraterException ex)
            {
                Assert.AreEqual("Null Rides", ex.Message);
            }
        }
    }
}