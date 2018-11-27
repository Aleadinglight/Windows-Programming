using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3_exercise3
{
    public class flight
    {
        //attributes
        CultureInfo dateCulture = new CultureInfo("fi-FI");
        string dateFormat = "dd/MM/yyyy";
        private string flightID;
        public string FlightID
        {
            get { return flightID; }
        }
        private string origin;
        public string Origin { get { return this.origin; } }
        private string destination;
        public string Destination { get { return this.destination; } }
        private DateTime date;
        /*private double price;
        //A read-write instance property
        public double Price { get { return this.price; } set { this.price = value; } }*/
        /*--------------------------------------------------------------------*/

        //constructor
        public flight()
        {
            this.flightID = "";
            this.origin = "";
            this.destination = "";
            this.date = new DateTime();
        }
        public flight(string inFlightID, string inOrigin, string inDestination, string inDate)
        {
            this.flightID = inFlightID;
            this.origin = inOrigin;
            this.destination = inDestination;
            DateTime.TryParseExact(inDate, dateFormat, dateCulture, DateTimeStyles.None, out this.date);
            //this.price = inPrice;
        }
        /*--------------------------------------------------------------------*/

        //method
        public override string ToString()
        {
            string res;
            res = "Flight ID: " + this.flightID + "\n";
            res += "Flight origin: " + this.origin + "\n";
            res += "Flight destination: " + this.destination + "\n";
            res += "Date : " + this.date.ToString(dateFormat)+ "\n";
            //res += "Price: " + this.price + "\n";
            return res;
        }
        public String findFlight(String inID)
        {
            if (this.flightID.Equals(inID))
                return this.ToString();
            return "";
        }
        public bool isWeekendFlight()
        {
            if (this.date.DayOfWeek == DayOfWeek.Saturday || this.date.DayOfWeek == DayOfWeek.Sunday)
                return true;
            else
                return false;
        }
    }
}
