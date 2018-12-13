using System;
using System.Collections.Generic;
using System.Text;

namespace Hw3
{
    class passenger
    {
        protected string passengerId;
        protected string firstName;
        protected string lastName;
        protected string phoneNumber;
        private List<Ticket> ticketList;

        public string PassengerId
        {
            get
            {
                return this.passengerId;
            }
        }
        

        // Constructor
        public passenger(string passengerId, string firstName, string lastName, string phoneNumber)
        {
            this.passengerId = passengerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.ticketList = new List<Ticket>();
        }

        
        public virtual void addTicket(Ticket t)
        {
            this.ticketList.Add(t);
        }

        public override string ToString()
        {
            string res = "";
            int iterate=0;
            res += "Passenger ID : " + passengerId + "\n";
            res += "First name: " + firstName + "\n";
            res += "Last name: " + lastName + "\n\n";
            res += "Tickets :\n\n";
            foreach (Ticket t in ticketList)
            {
                iterate++;
                res += iterate+". ";
                res += t.ToString()+"\n";
            }
            return res;
        }

        public virtual string getInfo(string passengerId)
        {
            if (this.passengerId.Equals(passengerId))
                return this.ToString();
            else
                return "";
        }
    }

    class EconomicPassenger : passenger
    {
        protected double luggageWeight;
        
        public EconomicPassenger(string passengerId, string firstName, string lastName, string phoneNumber, double luggageWeight) : base(passengerId, firstName, lastName, phoneNumber)
        {
            this.luggageWeight = luggageWeight;
        }

        public override string ToString()
        {
            return base.ToString()+ "All tickets include:\n*Luggage value : " + this.luggageWeight;
         
        }

        public override string getInfo(string Id)
        {
            if (this.passengerId.Equals(Id))
                return this.ToString();
            return "";
        }
    }

    class firstClassPassenger : EconomicPassenger
    {
        string mealMenu;
        double bonus = 0;
        public double Bonus {
            get
            {
                return this.bonus;
            }
        }

        public firstClassPassenger(string Id, string firstName, string lastName, string phoneNumber, double luggageWeight, string mealMenu) :
            base(Id, firstName, lastName, phoneNumber, luggageWeight)
        {
            this.mealMenu = mealMenu;
        }

        public override void addTicket(Ticket ticket)
        {
            base.addTicket(ticket);
            bonus += ticket.getPrice(ticket.TicketId) * 0.02;
        }

        public override string getInfo(string Id)
        {
            if (this.passengerId.Equals(Id))
                return this.ToString();
            return "";

        }
        public override string ToString()
        {
            return base.ToString()
                + "\n*Meal menu: " + this.mealMenu
                + "\n*Total bonus: " + this.bonus + "\n";
        }
    }
}
