using Horizon.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon.MVC.Models
{
    public class Flight : LogicFacade
    {
        public int FlightId { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public DateTime ArrivalDate { get; set; }
        public TimeSpan DepartTime { get; set; }
        public DateTime DepartDate { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public int AircraftID { get; set; }
    }
}