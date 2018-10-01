using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Customer
    {
        private string name;
        private int id, flightId;

        public Customer(string name, int id, int flightId)
        {
            this.name = name;
            this.id = id;
            this.flightId = flightId;
        }
        
        public string toString()
        {
            return "Name: " + name + "\nId: " + id + "\nFlight Id: " + flightId;
        }
            
    }
}
