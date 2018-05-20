using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportConsoleWCF
{
    class Database
    {
        public List<Connection> Connections { get; private set; }
        private static Database _database;

        public static Database GetInstance()
        {
            if (_database == null)
            {
                _database = new Database();
            }

            return _database;
        }

        private void Init()
        {
            Connections = new List<Connection>();
        }

        private Database()
        {
            Init();
            string path = "..\\..\\database.csv";
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Connections.Add(new Connection(values[0], values[1], values[2], values[3]));
                }
            }
        }

    }
}
