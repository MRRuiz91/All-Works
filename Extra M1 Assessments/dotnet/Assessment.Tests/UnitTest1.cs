using Assessment.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ActualTotalTest()
        {
            //Arrange
            HotelReservation res = new HotelReservation("test", 4);

            //Act
            double result = res.ActualTotal(false,false);

            //Assert
            Assert.AreEqual(239.96, result);

        }
    }
}
