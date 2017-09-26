using System;
using Xunit;
using HorizonDB;
using Horizon.Logic.Models;

namespace Horizon.Test
{
    public class UnitTest1
    {
        [Fact]
        public void cancel()
        {
            //Arrange
            Horizon.Logic.Models.Passenger x = new Logic.Models.Passenger();
            //Act
            var b= x.cancelFly(1);
            

            //Assert
            Assert.True(b);
            
        }
        [Fact]
        public void modify()
        {
            //Arrange
            Horizon.Logic.Models.Passenger x = new Logic.Models.Passenger();
            //Act
            var b = x.modifyFly(1,1,25);

            //Assert
            Assert.True(b);

        }
    }
}
