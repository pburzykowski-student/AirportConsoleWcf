using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportClientConsoleWCF.AirportServiceReference;

namespace AirportClientConsoleWCF
{
    class Timetable
    {
        private List<Connection> _connections;

        public Timetable()
        {
            _connections = new List<Connection>();
        }

        public void AddConnection(Connection connection)
        {
            _connections.Add(connection);
        }

        public void AddConnections(Connection[] connections)
        {
            _connections.AddRange(connections);
        }

        public void Show()
        {
            foreach(var c in _connections)
            {
                String s = String.Format("[{0} - {1}] to [{2} - {3}]", c.FromCity, c.StartTime, c.DestinationCity, c.ArrivalTime);
                Console.WriteLine(s);
            }
        }
    }
}
