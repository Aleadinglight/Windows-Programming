using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1B
{
    class customer
    {
        private string name;
        private string customerID;
        private string flightID;
        public string FlightID
        {
            get { return flightID; }
        }
        public customer()
        {
            this.name = "";
            this.flightID = "";
            this.customerID = "";
        }
        public customer(string inName, string inCutomerID, string inFlightID)
        {
            this.name = inName;
            this.customerID = inCutomerID;
            this.flightID = inFlightID;
        }

        public override string ToString()
        {
            string res;
            res = "Name: " + this.name + "\n";
            res += "Customer ID: " + this.customerID + "\n";
            res += "Flight ID: " + this.flightID + "\n";
            return res;
        }

        static public string find_customer_by_id(string ID, List<customer> customers, List<flight> flights)
        {
            string res = "";
            for (int i = 0; i < customers.Count; i++)
            {
                if (ID.Equals(customers[i].customerID))
                {
                    res += customers[i];
                    res += "This customer is on these flights: \n";
                    res += customers[i].find_flight_info(flights);
                }
            }
            return res;
        }

        public string find_flight_info(List<flight> flights)
        {
            string res = "";
            for (int i = 0; i < flights.Count; i++)
            {
                if (this.flightID.Equals(flights[i].FlightID))
                {
                    res += flights[i];
                }
            }
            return res;
        }
    }
}
