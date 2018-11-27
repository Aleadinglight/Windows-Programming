using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1601140_assignment3
{
    // a delegate to process a flight object
    public delegate string processFlight(flight f);
    public class Program
    {   
        static void Main(string[] args)
        {
            airlineCompany a = new airlineCompany("Finbuck");
            a.addNewFlight("FI12", "VAA", "HEL", "10/08/2019", 200.99);
            a.addNewFlight("FI13", "HEL", "SGN", "07/11/2019", 600.20);
            a.addNewFlight("FI14", "HEL", "VAA", "08/11/2019", 300.10);
            for(int i=0;i<a.numberOfFlight();i++)
                Console.WriteLine(a[i]);

            // This is for search demo
            /*string inFlightID = "";
            Console.WriteLine("Enter a flight ID to search");
            inFlightID = Console.ReadLine();
            flight res = a.findFlight(inFlightID);
            if(res != null)
                Console.WriteLine(res);
            else
                Console.WriteLine("Flight not found");*/

            Console.WriteLine("Enter price: \n");
            double inPrice;
            while (!double.TryParse(Console.ReadLine(), out inPrice))
            {
                Console.WriteLine("Incorrect format");
            }

            processFlight pfd;

            /*Console.WriteLine("Full flight info of flight less than {0:0.00} ", inPrice);
            pfd = new processFlight(delegateCollection.getFullFlightInfo);
            Console.WriteLine(a.processCheapFlight(pfd, inPrice));*/

            Console.WriteLine("Flight ID of flight less than {0:0.00} ", inPrice);
            pfd = new processFlight(delegateCollection.getIdOnly);
            Console.WriteLine(a.processCheapFlight(pfd, inPrice));

            Console.WriteLine("Destination of flight less than {0:0.00} ", inPrice);
            pfd = new processFlight(delegateCollection.getDestinationOnly);
            Console.WriteLine(a.processCheapFlight(pfd, inPrice));

            Console.WriteLine("Origin of flight less than {0:0.00} ", inPrice);
            pfd = new processFlight(delegateCollection.getDestinationOnly);
            Console.WriteLine(a.processCheapFlight(pfd, inPrice));
        }
    }
}
