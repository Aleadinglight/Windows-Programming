using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    // a delegate to process a flight object
    public delegate string processFlight(Flight f);
    public class Program
    {   
        static void Main(string[] args)
        {
            airlineCompany finAir = new airlineCompany("FinAir");
            finAir[0] = new Flight("TKO", "SGN", "VAA", "10/08/2019", 200.99);
            finAir[1] = new Flight("CTO", "LA", "SGN", "07/11/2019", 600.20);
            finAir[2] = new Flight("SAD","VAA", "HEL", "08/11/2019", 300.10);
          
            for (int i=0;i< finAir.flightCount();i++)
                Console.WriteLine(finAir[i]);

            // Find flight
            Console.Write("Find flight: ");
            string flightId = Console.ReadLine();
            Console.WriteLine("\n"+finAir.findFlight(flightId));

            // Enter the price
            Console.WriteLine("Enter price:");
            string temp = Console.ReadLine();
            double price = Double.Parse(temp);

            // Process
            processFlight pfd;

            Console.WriteLine("\nFlight ID of flight more than {0:0.00} ", price);
            pfd = new processFlight(delegateType.getFlightId);
            Console.WriteLine(finAir.applyDelegate(pfd, price));

            Console.WriteLine("Destination of flight more than {0:0.00} ", price);
            pfd = new processFlight(delegateType.getFlightDestination);
            Console.WriteLine(finAir.applyDelegate(pfd, price));

        }
    }
}
