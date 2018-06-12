using AirportClientConsoleWCF.AirportServiceReference;
using System;
using System.ServiceModel;

namespace AirportClientConsoleWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            AirportServiceClient client = new AirportServiceClient();
            
            Console.WriteLine(client.SayHello());
            Console.WriteLine();

            

            try
            {
                Timetable timetable = new Timetable();
                timetable.AddConnections(client.GetConnections("CityA", "CityE", TimeSpan.Parse("7:31"), TimeSpan.Parse("7:32")));
                timetable.Show();
            }
            catch (FaultException <ConnectionNotFoundFault> fault)
            {
                Console.WriteLine(fault.Detail.Message);
            }


            Console.ReadKey();
            client.Close();
        }
    }
}
