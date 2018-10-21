using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Flight
    {
        private string id, origin, destination, date;
        private List<string> Customers;

        public Flight(string id, string origin, string destination, string date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
            Customers = new List<string> { };
        }

        public void addCustomer(string name)
        {
            Customers.Add(name);
        }

        public List<string> getCustomer()
        {
            return Customers;
        }

        public string toString()
        {
            return "Flight id: " + this.id + "\nFrom: " + origin + "\nTo: " + destination + "\nDate: " + date;
        }
    }
}
