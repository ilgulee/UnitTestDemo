using System;
using NUnit.Framework;
using UnitTestDemo.Fundamentals;


namespace UnitTestDemo.UnitTests
{
    [TestFixture]
    public class ReservationTest
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            //Arrange
            var reservation=new Reservation();
           
            //Act
            var result=reservation.CanBeCancelledBy(new User {IsAdmin = true});
            
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_UserIsMadeBy_ReturnTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation{MadeBy = user};
            
            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.That(result,Is.True);
        }

        [Test]
        public void CanBeCancelledBy_UserIsNotAdminNorMadeBy_ReturnFalse()
        {
            //Arrange
            var reservation = new Reservation{MadeBy = new User()};
        
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false });

            //Assert
            Assert.That(result==false);
        }

    }
}
