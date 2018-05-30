using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo.Fundamentals;

namespace UnitTestDemo.UnitTests
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            //Arrange
            var reservation=new Reservation();
           
            //Act
            var result=reservation.CanBeCancelledBy(new User {IsAdmin = true});
            
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsMadeBy_ReturnTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation{MadeBy = user};
            
            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNotAdminNorMadeBy_ReturnFalse()
        {
            //Arrange
            var reservation = new Reservation{MadeBy = new User()};
        
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false });

            //Assert
            Assert.IsFalse(result);
        }

    }
}
