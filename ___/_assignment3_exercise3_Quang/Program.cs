using System;
using System.Collections.Generic;

namespace assignment3_exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            flight f = new flight("FI12", "Vaasa", "Helsinki", "10/11/2018"); //our flight

            //Some newly constructed ticket
            ticket ticket1 = new ticket("TIC1", "P01", f, 500.00);
            ticket ticket2 = new ticket("TIC2", "P01", f, 600.00);
            ticket ticket3 = new ticket("TIC3", "P02", f, 550.00);
            ticket ticket4 = new ticket("TIC4", "P02", f, 590.00);
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
                    if (p.PassID.Equals(test))
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
