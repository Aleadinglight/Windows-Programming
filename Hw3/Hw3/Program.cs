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
            airlineCompany a = new airlineCompany("Finbuck");
            a.addNewFlight("VIVA", "SGN", "VAASA", "10/08/2019", 200.99);
            a.addNewFlight("GAY", "LA", "SGN", "07/11/2019", 600.20);
            a.addNewFlight("SAD", "", "VAA", "08/11/2019", 300.10);

            for(int i=0;i<a.flightCount();i++)
                Console.WriteLine(a[i]);

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
            pfd = new processFlight(delegateType.getFlightId);
            Console.WriteLine(a.applyDelegate(pfd, inPrice));

            Console.WriteLine("Destination of flight less than {0:0.00} ", inPrice);
            pfd = new processFlight(delegateType.getFlightDestination);
            Console.WriteLine(a.applyDelegate(pfd, inPrice));

            Console.WriteLine("Origin of flight less than {0:0.00} ", inPrice);
            pfd = new processFlight(delegateType.getFlightDestination);
            Console.WriteLine(a.applyDelegate(pfd, inPrice));
        }
    }
}
