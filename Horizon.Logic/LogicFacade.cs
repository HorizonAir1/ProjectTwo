using Horizon.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon.Logic
{
  public class LogicFacade
  {
    public List<List<string>> GetAllFlights(string startLoc, string destLoc, DateTime startSearch, DateTime endSearch, int numPassengers)
    {
      throw new NotImplementedException();
    }

    public bool CancelFlight(string customerId, string flightId)
    {
      throw new NotImplementedException();
    }

    public bool ModifyFlight(string customerId, string flightId, string seatId)
    {
      throw new NotImplementedException();
    }

    public bool RegisterToFlight(string customerId, string flightId)
    {
      throw new NotImplementedException();
    }

    public bool RegisterToFlight(ICustomer customer, string flightId)
    {
      throw new NotImplementedException();
    }

    public List<string>() GetAllFlightDestinations()
    {
      return Flight.GetAllFlightDestinations();
    }

    public List<List<string>> GetAllFlights()
    {
      return Flight.GetAllFlights()l;
    }
  }
}
