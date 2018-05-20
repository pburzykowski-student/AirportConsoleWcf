using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

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
        List<Connection> GetConnections(String fromCity, String destinationCity);
    }
}
