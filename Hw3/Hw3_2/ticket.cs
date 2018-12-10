using System;
using System.Collections.Generic;
using System.Text;

namespace Hw3
{
    class Ticket
    {

        private string ticketId;
        private string passengerId;
        private Flight flight;
        private readonly double price;
        private readonly int extraTax;

        public string TicketId {
            get 
            {
                return this.ticketId;
            }
        }

        // Constructor
        public Ticket(string ticketId, string passengerId, Flight flight, double price)
        {
            this.ticketId = ticketId;
            this.passengerId = passengerId;
            this.flight = flight;
            this.price = price;
            extraTax = (this.flight.isWeekend() ? 7 : 5);
        }

        
        public override string ToString()
        {
            return "Ticket ID: " + this.ticketId 
                + "\nPassenger ID: " + this.passengerId 
                + "\nFlight info: "+ this.flight.ToString()
                + "Ticket price : " + this.price 
                + "\nExtraTax : " + this.extraTax 
                + "\nTotal price : " + this.getPrice(this.ticketId) + "\n";
        }

        public double getPrice(string ticketId)
        {
            return price * (100 + extraTax) / 100;
        }

        public string getFlightInfo(List<passenger> passengerList)
        {
            string res = "This ticket info: \n";
            res += this.ToString();
            foreach (passenger p in passengerList)
            {
                if (this.passengerId.Equals(p.PassengerId))
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
