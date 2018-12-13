using System;
using System.Collections.Generic;

namespace Hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight f = new Flight("FI12", "Vaasa", "Helsinki"); 

            // Initiate tickets
            Ticket ticket1 = new Ticket("TIC1", "P01", f, 100.10);
            Ticket ticket2 = new Ticket("TIC2", "P02", f, 200.20);
            Ticket ticket3 = new Ticket("TIC3", "P03", f, 300.30);
            EconomicPassenger ecoPassenger = new EconomicPassenger("eco01", "Donald", "Trump", "0123", 10);
            firstClassPassenger fcPassenger = new firstClassPassenger("fc01", "John", "Wick", "4567", 20, "Noodles");

            // Add tickets to first class passenger
            ecoPassenger.addTicket(ticket1);
            
            // Add tickets to first class passenger
            fcPassenger.addTicket(ticket2);
            fcPassenger.addTicket(ticket3);

            List<passenger> passengersList = new List<passenger>();
            passengersList.Add(ecoPassenger);
            passengersList.Add(fcPassenger);

            Console.WriteLine(ticket1.getFlightInfo(passengersList)) ;

            Console.WriteLine("Search for passenger ID: ");
            string passengerSearchInput = Console.ReadLine();

            string ans = "";
            foreach (passenger p in passengersList)
            {
                ans += p.getInfo(passengerSearchInput);
            }
            Console.WriteLine("Result:\n"+ans+"\n");
            if (ans.Equals(""))
            {
                Console.WriteLine("ID not found\n");
            }
         
        }   
    }
}
