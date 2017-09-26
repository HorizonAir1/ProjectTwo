using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Horizon.Logic.Models;
using HorizonDB;

namespace Horizon.Logic.Tests
{
  public class FlightTests
  {
    [Fact]
    public void BookTest()
    {
      int initcount = 0;
      using (var db = new HorizonEntities())
      {
        initcount = db.Bookings.Count();
      }
      Flight.BookPassenger(1, 1, 1, 1, 1);

      int aftercount = 0;
      using (var db = new HorizonEntities())
      {
        aftercount = db.Bookings.Count();
      }
      var actual = aftercount == initcount + 1;
      Assert.True(actual);
    }

    [Fact]
    public void GetAllFlightsTest()
    {
      Assert.True(true);
    }
  }
}
