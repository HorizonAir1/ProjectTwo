using HorizonDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon.Logic.Abstracts
{
  public class Flight
  {
    public int FlightId { get; set; }
    public string ArrivalDate { get; set; }
    public string ArrivalTime { get; set; }
    public string DepartureDate { get; set; }
    public string DepartureTime { get; set; }
    public string TakeOffLoc { get; set; }
    public string Destination { get; set; }

    DateTime ArrivalDT { get; set; }
    DateTime DepartureDT { get; set; }

    public bool BookPassenger(int passenger_id, int seatClass,  int seatNumber)
    {
      using (var db = new HorizonEntities())
      {
        Booking addB = new Booking()
        {
          passenger_id = passenger_id,
          flight_id = FlightId,
          seatclass_id= seatClass,
          seat_number = seatNumber,
          baggage_num = 0,
          status_id= 1,
        };
        db.Bookings.Add(addB);
        db.SaveChanges();
      }

      throw new NotImplementedException();
    }

    public static Flight GetFlight(string flightId)
    {
      throw new NotImplementedException();
    }

    public List<string> ToList()
    {
      throw new NotImplementedException();
    }

    public List<string> GetAvailableSeats()
    {
      throw new NotImplementedException();
    }

  }
}
