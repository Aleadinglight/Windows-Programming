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
        private  List<string> flightIds;
        private int id;

        public Customer(string name, int id)
        {
            this.name = name;
            this.id = id;
            flightIds = new List<string> { };
        }

        public void addFlight(string newFlightId)
        {
            flightIds.Add(newFlightId);
        }
        // returns the customer's and his/her flight's info.
        public string toString()
        {
            string information =  "Name: " + name + "\nId: " + id + "\nFlight Id: ";
            foreach (var flight in flightIds)
            {
                information += flight + ",";
            }
            information = information.Remove(information.Length - 1);
            return information;
        }
            
    }
}
