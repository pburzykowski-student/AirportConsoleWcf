using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace AirportConsoleWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8000/AirportConsoleWCF/");
            ServiceHost selfHost = new ServiceHost(typeof(AirportService), baseAddress);

            try
            {
                selfHost.AddServiceEndpoint(typeof(IAirportService), new WSHttpBinding(), "AirportService");

                ServiceMetadataBehavior serviceMetadataBehavior =
                    new ServiceMetadataBehavior()
                    {
                        HttpGetEnabled = true
                    };

                selfHost.Description.Behaviors.Add(serviceMetadataBehavior);

                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine();
                Console.WriteLine("Press any key to terminate service.");
                Console.ReadKey();

                selfHost.Close();
            }
            catch (CommunicationException e)
            {
                Console.WriteLine("An exception occurred: {0}", e.Message);
                selfHost.Abort();
            }
            finally
            {
                
                Console.ReadKey();
            }
        }
    }
}
