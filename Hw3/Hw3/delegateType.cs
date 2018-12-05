using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    class delegateType
    {
        public static string getFlightInfo(Flight f)
        {
            return f.ToString();
        }
        public static string getFlightId(Flight f)
        {
            return (f.FlightID+"\n");
        }
        public static string getFlightOrigin(Flight f)
        {
            return (f.Origin+"\n");
        }
        public static string getFlightDestination(Flight f)
        {
            return (f.Destination+"\n");
        }
    }
}
