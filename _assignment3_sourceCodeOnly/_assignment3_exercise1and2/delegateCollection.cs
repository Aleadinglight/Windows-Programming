 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1601140_assignment3
{
    class delegateCollection
    {
        public static string getFullFlightInfo(flight f)
        {
            return f.ToString();
        }
        public static string getIdOnly(flight f) { return (f.FlightID+"\n"); }
        public static string getOriginOnly(flight f) { return (f.Origin+"\n"); }
        public static string getDestinationOnly(flight f) { return (f.Destination+"\n"); }
    }
}
