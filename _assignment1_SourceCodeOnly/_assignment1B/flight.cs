using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1B
{
    class flight
    {
        private string flightID;
        public string FlightID
        {
            get { return flightID; }
        }
        private string origin;
        private string destination;
        private string date;
        public flight()
        {
            this.flightID = "";
            this.origin = "";
            this.destination = "";
            this.date = "";
        }
        public flight(string inFlightID, string inOrigin, string inDestination, string inDate)
        {
            this.flightID = inFlightID;
            this.origin = inOrigin;
            this.destination = inDestination;
            this.date = inDate;
        }
        public override string ToString()
        {
            string res;
            res = "Flight ID: " + this.flightID + "\n";
            res += "Flight origin: " + this.origin + "\n";
            res += "Flight destination: " + this.destination + "\n";
            res += "Date : " + this.date + "\n";
            return res;
        }
        static public string find_flight_by_ID(string ID, List<flight> flights, List<customer> customers)
        {
            string res = "";
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].flightID.Equals(ID))
                {
                    res += flights[i];
                    res += "Customers on this flight: \n";
                    res += flights[i].find_customer_info(customers);
                }
            }
            return res;
        }
        public string find_customer_info(List<customer> customers)
        {
            string res = "";
            for (int i = 0; i < customers.Count; i++)
            {
                if (this.flightID.Equals(customers[i].FlightID))
                {
                    res += customers[i];
                }
            }
            return res;
        }
    }
}
