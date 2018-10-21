using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add customers to a List
            var CustomersList = new List<Customer> {};
            CustomersList.Add(new Customer("John", 1,"A"));
            CustomersList.Add(new Customer("Tom", 2, "B"));
            CustomersList.Add(new Customer("Jenni", 3, "A"));
            CustomersList.Add(new Customer("Mark", 4, "C"));

            // Add flights to a List
            // string id, string origin, string destination, string date
            var FlightsList = new List<Flight> {};
            FlightsList.Add(new Flight("A", "Vaa", "Hel", "1/10/2018"));

        }
    }
}
