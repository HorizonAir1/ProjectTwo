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
    public bool CancelFlight(int user, int flightId)
    {
      return Passenger.cancelFly(user, flightId);
    }

    public bool ModifyFlight(int user, int flightId, int seat)
    {
      return Passenger.modifyFly(user, flightId, seat)
    }

    public bool BookToFlight()
    {

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
