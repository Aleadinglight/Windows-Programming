using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace assignment1B
{
    class Program
    {
        static void printMenu()
        {
            Console.WriteLine("Press 1 to add new customer");
            Console.WriteLine("Press 2 to add new flight");
            Console.WriteLine("Press 3 to view all customers");
            Console.WriteLine("Press 4 to view all flights");
            Console.WriteLine("Press 5 to search flight by ID");
            Console.WriteLine("Press 6 to search customer by ID");
            Console.WriteLine("Enter 0 to exit");
        }
        static void get_new_customer(ref customer inCustomer)
        {
            string inName, inCustomerID, inFlightID;
            Console.Write("Enter name: ");
            inName = Console.ReadLine();
            Console.Write("Enter customer ID: ");
            inCustomerID = Console.ReadLine();
            Console.Write("Enter flight ID: ");
            inFlightID = Console.ReadLine();
            inCustomer = new customer(inName, inCustomerID, inFlightID);
        }
        static void get_new_flight(ref flight inFlight)
        {
            string inFlightID, inOrigin, inDestination, inDate;
            Console.Write("Enter flight ID: ");
            inFlightID = Console.ReadLine();
            Console.Write("Enter flight origin: ");
            inOrigin = Console.ReadLine();
            Console.Write("Enter flight destination: ");
            inDestination = Console.ReadLine();
            Console.Write("Enter flight date: ");
            inDate = Console.ReadLine();
            inFlight = new flight(inFlightID, inOrigin, inDestination, inDate);
        }
        static void Main(string[] args)
        {
            List<customer> customerList = new List<customer>();
            List<flight> flightList = new List<flight>();

            //initial values of customerList
            customer customerTemp = new customer("Huy", "123", "FI12");
            customerList.Add(customerTemp);
            customerTemp = new customer("Han", "124", "FI12");
            customerList.Add(customerTemp);

            //initial values of flightList
            flight flightTemp = new flight("FI12", "VAA", "HEL", "10/08/2018");
            flightList.Add(flightTemp);
            flightTemp = new flight("FI13", "HEL", "SGN", "11/08/2018");
            flightList.Add(flightTemp);
            flightTemp = new flight("FI12", "SGN", "HEL", "12/09/2018");
            flightList.Add(flightTemp);
            while (true)
            {
                int choice;
                try
                {
                    Program.printMenu();
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            System.Environment.Exit(1);
                            break;
                        case 1:
                            Console.WriteLine("Enter new customer: ");
                            customer tempCustomer = new customer();
                            Program.get_new_customer(ref tempCustomer);
                            customerList.Add(tempCustomer);
                            break;
                        case 2:
                            Console.WriteLine("Enter new flight: ");
                            flight tempFlight = new flight();
                            Program.get_new_flight(ref tempFlight);
                            flightList.Add(tempFlight);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Customers in the list: ");
                            foreach (var currentCustomer in customerList)
                            {
                                Console.WriteLine(currentCustomer);
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Flights in the list: ");
                            foreach (var currentFlight in flightList)
                            {
                                Console.WriteLine(currentFlight);
                            }
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Enter flights ID: ");
                            String flightID = Console.ReadLine();
                            Console.WriteLine("Search result: ");
                            Console.WriteLine(flight.find_flight_by_ID(flightID, flightList, customerList));
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("Enter customer ID: ");
                            String customerID = Console.ReadLine();
                            Console.WriteLine("Search result: ");
                            Console.WriteLine(customer.find_customer_by_id(customerID, customerList, flightList));
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    //Console.Clear();
                }
                catch (FormatException f)
                {
                    Console.WriteLine("ERROR! Integer numbers only");
                }
                //Console.ReadLine();
            }
        }
    }
}
