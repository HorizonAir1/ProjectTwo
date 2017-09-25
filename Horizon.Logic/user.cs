using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorizonDB;

namespace Horizon.Logic
{
    public class user
    {
        public List<string> getFlights(int y)
        {
            using (var db = new horizonDBEntity())
            {
                Flight flights = new Flight();
                List<string> flightList = new List<string>();
                foreach( Flight fli in db.Flights)
                {
                    flightList.Add(fli.flight_id.ToString());
                }
                return flightList;
            }
        }
        public List<string> getFlights(DateTime x,DateTime y)
        {
            using (var db = new horizonDBEntity())
            {
                Flight flights = new Flight();
                List<string> flightList = new List<string>();
                foreach (Flight fli in db.Flights)
                {
                    flightList.Add(fli.flight_id.ToString());
                }
                return flightList;
            }
        }

    }
}
