using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Customer
    {
        private string name, flightId;
        private int id;

        public Customer(string name, int id, string flightId)
        {
            this.name = name;
            this.id = id;
            this.flightId = flightId;
        }
        // returns the customer's and his/her flight's info.
        public string toString()
        {
            return "Name: " + name + "\nId: " + id + "\nFlight Id: " + flightId;
        }
            
    }
}
