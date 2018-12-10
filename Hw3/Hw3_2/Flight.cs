using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Hw3
{
    public class Flight
    {
        private string flightID, origin, destination;
        CultureInfo dateCulture = new CultureInfo("fi-FI");
        string dateFormat = "dd/MM/yyyy";
        private DateTime date;

       
        public string FlightID
        {
            get
            {
                return flightID;
            }
        }
        public string Origin
        {
            get
            {
                return this.origin;
            }
        }
        public string Destination
        {
            get
            {
                return this.destination;
            }
        }
        public string Date
        {
            get
            {
                return this.date.ToString();
            }
        }

        // Constructor
        public Flight(string flightID, string origin, string destination)
        {
            this.flightID = flightID;
            this.origin = origin;
            this.destination = destination;
            this.date = new DateTime();
        }

        public override string ToString()
        {
            return "Flight ID: " + this.flightID
                + "\nFlight origin: " + this.origin
                + "\nFlight destination: " + this.destination
                + "\nDate : " + this.date + "\n";

        }

        public string findFlight(string flightID)
        {
            if (this.flightID.Equals(flightID))
            {
                return this.ToString();
            }
            return "";
        }

        public bool isWeekend()
        {
            if (this.date.DayOfWeek == DayOfWeek.Saturday || this.date.DayOfWeek == DayOfWeek.Sunday)
                return true;
            else
                return false;
        }
    }
}
