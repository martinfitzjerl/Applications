using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplicationDevelopingSam.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_AdminUserCancelsReservation_ReturnsTrue()
        {
            //Arrange
            Reservation reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });


            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancelsReservation_ReturnsTrue()
        {
            //Arrange
            User user = new User();
            Reservation reservation = new Reservation { MadeBy = user };


            //Act
            var result = reservation.CanBeCancelledBy(user);


            //Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void CanBeCancelledBy_DifferentUserCancelsReservation_ReturnsFalse()
        {
            //Arrange
            User user = new User();
            Reservation reservation = new Reservation();


            //Act
            var result = reservation.CanBeCancelledBy(new User());


            //Assert
            Assert.IsFalse(result);
        }
    }
}
