using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CustomException;

namespace AirportConsoleWCF
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    [ServiceKnownType(typeof(Connection))]
    public interface IAirportService
    {
        [OperationContract]
        String SayHello();

        [OperationContract]
        Connection GetConnection(int number);

        [OperationContract]
        List<Connection> GetAllConnections();

        [OperationContract]
        [FaultContract(typeof(ConnectionNotFoundFault))]
        List<Connection> GetConnections(String fromCity, String destinationCity, TimeSpan departureTime, TimeSpan arrivalTime);
    }
}
