using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Horizon.Logic;

namespace Horizon.Tests
{
    public class Class1
    {
        [Fact]
        public void cancel()
        {
            //Arrange

            //Act
            var b = Horizon.Logic.Models.Passenger.cancelFly(1,1);


            //Assert
            Assert.True(b);

        }
        [Fact]
        public void modify()
        {
            //Arrange

            //Act
            var b = Horizon.Logic.Models.Passenger.modifyFly(1, 1, 25);

            //Assert
            Assert.True(b);

        }
    }
}
