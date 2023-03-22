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
    }
}