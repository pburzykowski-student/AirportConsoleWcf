using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CustomException
{


    [DataContract]
    public class ConnectionNotFoundFault
    {
        [DataMember]
        private string _message;

        public ConnectionNotFoundFault(string message)
        {
            _message = message;
        }

        [DataMember]
        public string Message { get { return _message; } set { _message = value; } }

    }


}
