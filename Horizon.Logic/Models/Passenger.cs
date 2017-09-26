using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorizonDB;
namespace Horizon.Logic.Models
{
    public class Passenger
    {
        public bool cancelFly(int y )
        {
            using (var db = new HorizonEntities())
            {
               Booking cancelB = db.Bookings.Single(x => x.Passenger.passenger_id == y);
               if(cancelB != null)
                {
                    cancelB.status_id = 2;
                    db.SaveChanges();
                    return true;
                }
                
                return false;
            }
        }
        public bool modifyFly(int user , int flight , int seat )
        {
            using (var db = new HorizonEntities())
            {
                Booking cancelB = db.Bookings.Single(x => x.Passenger.passenger_id == user);
                if (cancelB != null)
                {
                    cancelB.Flight.flight_id = flight;
                    cancelB.seat_number = seat;
                    db.SaveChanges();
                    return true;
                }
                return false;
                
            }
        }
     
    }
}
