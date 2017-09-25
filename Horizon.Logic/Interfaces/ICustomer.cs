using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon.Logic.Interfaces
{
  public interface ICustomer
  {
    string FirstName { get; set; }
    string LastName { get; set; }
    string Address { get; set; }

  }
}
