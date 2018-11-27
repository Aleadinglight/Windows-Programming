using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1601140_assignment3
{
    public class flight
    {
        //attributes
        private string flightID;
        public string FlightID
        {
            get { return flightID; }
        }
        private string origin;
        public string Origin { get { return this.origin; } } 
        private string destination;
        public string Destination { get { return this.destination; } }
        private string date;
        private double price;
        //A read-write instance property
        public double Price { get { return this.price; } set { this.price = value; } }
        /*--------------------------------------------------------------------*/

        //constructor
        public flight()
        {
            this.flightID = "";
            this.origin = "";
            this.destination = "";
            this.date = "";
        }
        public flight(string inFlightID, string inOrigin, string inDestination, string inDate, double inPrice)
        {
            this.flightID = inFlightID;
            this.origin = inOrigin;
            this.destination = inDestination;
            this.date = inDate;
            this.price = inPrice;
        }
        /*--------------------------------------------------------------------*/

        //method
        public override string ToString()
        {
            string res;
            res = "Flight ID: " + this.flightID + "\n";
            res += "Flight origin: " + this.origin + "\n";
            res += "Flight destination: " + this.destination + "\n";
            res += "Date : " + this.date + "\n";
            res += "Price: " + this.price +"\n";
            return res;
        }
        public String findFlight(String inID)
        {
            if (this.flightID.Equals(inID))
                return this.ToString();
            return "";
        } 
    }
}
