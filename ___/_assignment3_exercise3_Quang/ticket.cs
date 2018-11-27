using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3_exercise3
{
    class ticket
    {
        /* Attribute of ticket class*/
        private string ticketID;
        private string passengerID;
        private flight f;              //flight of this ticket
        private readonly double price;
        private readonly int extraTax;

        /* Constructor*/
        public ticket(string inTicketID, string inPassengerID, flight inFlight, double inPrice)
        {
            this.ticketID = inTicketID;
            this.passengerID = inPassengerID;
            this.f = inFlight;
            this.price = inPrice;
            extraTax = (f.isWeekendFlight() ? 7 : 5);
        }

        /* Method of ticket class*/
        public override string ToString()
        {
            string res = "";
            res += "Ticket ID: " + this.ticketID + "\n";
            res += "Passenger ID: " + this.passengerID + "\n";
            res += "Flight info: \n" + this.f.ToString();
            res += "Ticket price : " + this.price + "\n";
            res += "ExtraTax : " + this.extraTax + "\n";
            res += "Total price : " + this.getPrice() + "\n";
            return res;
        }

        public double getPrice()
        {
            return price * (100 + extraTax) / 100;
        }

        public string getFlightInfo(List<passenger> pL)
        {
            string res = "This ticket info: \n";
            res += this.ToString();
            foreach (passenger p in pL)
            {
                if (this.passengerID.Equals(p.PassID))
                {
                    res += "++++++++++++++++++++++++++++++++\n";
                    res += "passenger has this ticket: \n";
                    res += p.ToString();
                }
            }
            return res;
        }

    }
}
