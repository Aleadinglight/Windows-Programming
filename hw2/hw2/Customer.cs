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
            return "Name: " + name + "Id: " + id + "Flight Id: " + flightId;
        }
            //git commit --date="Mon Oct 1 11:00 2018 +0100" -m "added customer class"
    }
}
