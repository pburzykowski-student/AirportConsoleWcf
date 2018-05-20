using System;
using System.Collections.Generic;

namespace AirportConsoleWCF
{
    class ConnectionSearchEngine
    {
        private Database _database;

        public ConnectionSearchEngine(Database database)
        {
            _database = database;
        }

        public List<Connection> SearchConnection(String fromCity, String destinationCity)
        {
            List<Connection> connections = new List<Connection>(_database.Connections);

            foreach (var c in connections)
            {
                Console.WriteLine(c.FromCity);
                Console.WriteLine(c.DestinationCity);
                Console.WriteLine();
            }

            List<Connection> searchConnections = new List<Connection>();

            Connection connection;
            String findCity = fromCity;

            int i = 0;
            do
            {
                Console.WriteLine(i++);
                if (connections.Count == 0)
                {
                    throw new CustomException.ConnectionNotFoundException();
                }

                connection = connections.Find(x => x.FromCity.Equals(findCity));

                if (connection == null)
                {
                    findCity = fromCity;
                    if(connections.Find(x => x.FromCity.Equals(findCity)) != null)
                    {
                        searchConnections.Clear();
                        continue;
                    } else
                    {
                        throw new CustomException.ConnectionNotFoundException();
                    }
                }

                searchConnections.Add(connection);
                connections.Remove(connection);
                findCity = connection.DestinationCity;

                Console.WriteLine("======");
                Console.WriteLine(connection.DestinationCity);
                Console.WriteLine(destinationCity);
                Console.WriteLine("======");
                if (connection.DestinationCity.Equals(destinationCity))
                {
                    return searchConnections; 
                }

            } while (true);

        }

        
    }
}
