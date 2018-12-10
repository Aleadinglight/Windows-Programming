using System;
using System.Collections.Generic;

namespace Hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight f = new Flight("FI12", "Vaasa", "Helsinki"); //our flight

            //Some newly constructed ticket
            Ticket ticket1 = new Ticket("TIC1", "P01", f, 500.00);
            Ticket ticket2 = new Ticket("TIC2", "P01", f, 600.00);
            Ticket ticket3 = new Ticket("TIC3", "P02", f, 550.00);
            Ticket ticket4 = new Ticket("TIC4", "P02", f, 590.00);
            economicPassenger ePass = new economicPassenger("P01", "Huy", "Nguyen", "0123123", 21);
            firstClassPassenger fcPass = new firstClassPassenger("P02", "Huy", "Nguyen", "123333", 21, "Vegetable only");

            ePass.addTicket(ticket1);
            ePass.addTicket(ticket2);

            fcPass.addTicket(ticket3);
            fcPass.addTicket(ticket4);
            List<passenger> pLists = new List<passenger>();
            pLists.Add(ePass);
            pLists.Add(fcPass);

            /*foreach(passenger p in pLists) {
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine(p);
            }*/
            Console.Write(ticket1.getFlightInfo(pLists)) ;
            string test = "";
            bool found = false;
            while (!test.Equals("quit"))
            {
                Console.WriteLine("Give a passenger ID: ");
                test = Console.ReadLine();
                Console.WriteLine("Search for ID: " + test);
                foreach(passenger p in pLists)
                {
                    if (p.PassengerId.Equals(test))
                    {
                        Console.WriteLine("Customer with this ID: ");
                        Console.WriteLine(p);
                        found = true;
                        break;
                    }
                }
                if(found == false)
                {
                    Console.WriteLine("ID not found");
                }
            }
        }   
    }
}
