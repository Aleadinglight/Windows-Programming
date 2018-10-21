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
            CustomersList.Add(new Customer("John", 1));
            CustomersList.ElementAt(0).addFlight("A");
            CustomersList.ElementAt(0).addFlight("B");

            CustomersList.Add(new Customer("Tom", 2));
            CustomersList.ElementAt(1).addFlight("B");

            CustomersList.Add(new Customer("Jenni", 3));
            CustomersList.ElementAt(2).addFlight("C");

            CustomersList.Add(new Customer("Mark", 4));
            CustomersList.ElementAt(3).addFlight("A");


            // Add flights to a List
            // string id, string origin, string destination, string date
            var FlightsList = new List<Flight> {};
            FlightsList.Add(new Flight("A", "Tokyo", "Helsinki", "1/10/2018"));
            FlightsList.Add(new Flight("B", "USA", "Russia", "10/12/2018"));
            FlightsList.Add(new Flight("C", "Germany", "Sweden", "1/4/2018"));

        }
    }
}
