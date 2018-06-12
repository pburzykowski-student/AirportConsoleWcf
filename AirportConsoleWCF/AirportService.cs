using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CustomException;

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

        public List<Connection> GetConnections(string fromCity, string destinationCity, TimeSpan departureTime, TimeSpan arrivalTime)
        {
            List<Connection> connections = null;
            try
            {
                 connections = _connectionSearchEngine.SearchConnection(fromCity, destinationCity, departureTime, arrivalTime);
            }
            catch (ConnectionNotFoundException e)
            {
                throw new FaultException<ConnectionNotFoundFault>(new ConnectionNotFoundFault("Connection not found"));
            }

            return connections;
            
        }

        public string SayHello()
        {
            return "Hello World!";
        }

    }
}
