using AirportClientConsoleWCF.AirportServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportClientConsoleWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            AirportServiceClient client = new AirportServiceClient();
            Console.WriteLine(client.SayHello());
            Console.WriteLine();

            Timetable timetable = new Timetable();
            timetable.AddConnections(client.GetConnections("CityA", "CityD"));
            timetable.Show();

            Console.ReadKey();
            client.Close();
        }
    }
}
