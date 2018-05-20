using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AirportConsoleWCF
{
    [DataContract]
    public class Connection
    {
        [DataMember]
        public string FromCity { get; private set; }

        [DataMember]
        public string DestinationCity { get; private set; }

        [DataMember]
        public TimeSpan StartTime { get; private set; }

        [DataMember]
        public TimeSpan ArrivalTime { get; private set; }

        public Connection(string fromCity, string destinationCity, string startTime, string arrivalTime)
        {
            FromCity = fromCity;
            DestinationCity = destinationCity;
            StartTime = TimeSpan.Parse(startTime);
            ArrivalTime = TimeSpan.Parse(arrivalTime);
        }

    }
}
