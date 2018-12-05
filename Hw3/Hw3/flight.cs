using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    public class Flight
    {
        private string flightID, origin, destination, date;
        private double price;

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
                return this.date;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        // Constructor
        public Flight()
        {
            this.flightID = "";
            this.origin = "";
            this.destination = "";
            this.date = "";
        }
        public Flight(string flightID, string origin, string destination, string date, double price)
        {
            this.flightID = flightID;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
            this.price = price;
        }
     
        public override string ToString()
        {
            return "Flight ID: " + this.flightID 
                + "\nFlight origin: " + this.origin 
                + "\nFlight destination: " + this.destination 
                + "\nDate : " + this.date 
                + "\nPrice: " + this.price +"\n";
          
        }
        public String findFlight(String fligtID)
        {
            if (this.flightID.Equals(flightID))
                return this.ToString();
            return "";
        } 
    }
}
