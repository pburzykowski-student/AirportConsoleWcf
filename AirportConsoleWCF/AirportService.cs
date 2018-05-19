using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportConsoleWCF
{
    class AirportService : IAirportService
    {
        public string SayHello()
        {
            return "Hello World!";
        }
    }
}
