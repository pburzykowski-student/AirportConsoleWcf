using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportConsoleWCF
{
    class AirportService : IAirportService
    {
        private Database _database = Database.GetInstance();
        private ConnectionSearchEngine _connectionSearchEngine;

        public AirportService()
        {
            _database = Database.GetInstance();
            _connectionSearchEngine = new ConnectionSearchEngine(_database);
        }

        public Connection GetConnection(int number)
        {
            return _database.Connections[number];
        }

        public List<Connection> GetAllConnections()
        {
            return _database.Connections;
        }

        public List<Connection> GetConnections(string fromCity, string destinationCity)
        {
            return _connectionSearchEngine.SearchConnection(fromCity, destinationCity);
        }

        public string SayHello()
        {
            return "Hello World!";
        }
    }
}
