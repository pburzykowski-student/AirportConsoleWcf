using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AirportConsoleWCF
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IAirportService
    {
        [OperationContract]
        String SayHello();
    }
}
