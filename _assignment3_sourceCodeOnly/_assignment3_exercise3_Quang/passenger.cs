using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3_exercise3
{
    class passenger
    {
        /* Attribute pf passenger class*/
        protected string passengerID;
        public string PassID { get { return this.passengerID; } }
        protected string firstName;
        protected string lastName;
        protected string phoneNumber;
        List<ticket> ticketList;

        /* Constructor*/
        public passenger() { }
        public passenger(string ID, string inFirstName, string inLastName, string inPhoneNumber)
        {
            this.passengerID = ID;
            this.firstName = inFirstName;
            this.lastName = inLastName;
            this.phoneNumber = inPhoneNumber;
            this.ticketList = new List<ticket>();
        }

        /* Method of this class*/
        public virtual void addTicket(ticket t)
        {
            this.ticketList.Add(t);
        }
        public override string ToString()
        {
            string res = "";
            res += "Passenger ID : " + passengerID + "\n";
            res += "First name: " + firstName + "\n";
            res += "Last name: " + lastName + "\n";
            res += "Tickets :\n";
            foreach (ticket t in ticketList)
            {
                res += "*********new ticket**********\n";
                res += t.ToString();
            }
            return res;
        }
        public virtual string getInfo(string ID)
        {
            if (this.passengerID.Equals(ID))
                return this.ToString();
            else
                return null;
        }
    }
    class economicPassenger : passenger
    {
        protected double luggageValue;
        public economicPassenger() { }
        public economicPassenger(string ID, string inFirstName, string inLastName, string inPhoneNumber, double inLuggageValue) : base(ID, inFirstName, inLastName, inPhoneNumber)
        {
            this.luggageValue = inLuggageValue;
        }
        public override string ToString()
        {
            string res = base.ToString();
            res += "**********extra information*********\n";
            res += "Luggage value : " + this.luggageValue + "\n";
            return res;
        }
        public override string getInfo(string ID)
        {
            if (this.passengerID.Equals(ID))
                return this.ToString();
            else
                return null;
        }
    }
    class firstClassPassenger : economicPassenger
    {
        string mealMenu;
        double bonus = 0;
        public double Bonus { get { return this.bonus; } }
        public firstClassPassenger(string ID, string inFirstName, string inLastName, string inPhoneNumber, double inLuggageValue, string inMealMenu) :
            base(ID, inFirstName, inLastName, inPhoneNumber, inLuggageValue)
        {
            this.mealMenu = inMealMenu;
        }
        public override void addTicket(ticket t)
        {
            base.addTicket(t);
            bonus += t.getPrice() * 0.02;
        }
        public override string getInfo(string ID)
        {
            string res = base.getInfo(ID);
            res += " Bonus : " + this.bonus + "\n";
            return res;
        }
        public override string ToString()
        {
            string res = base.ToString();
            res += "Meal : "+this.mealMenu+"\n";
            res += "Total bonus: " + this.bonus + "\n";
            return res;
        }
    }
}
