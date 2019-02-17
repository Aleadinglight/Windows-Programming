using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiate the sights
            Sight s1 = new Sight("A","1/1/1998","1A WallStreet", 10.0, 100.10);
            Sight s2 = new Sight("B", "2/2/1998", "1A Washington DC", 20.0, 200.20);
            Sight s3 = new Sight("C", "3/3/1998", "1A Mountain View DC", 30.0, 300.30);

            // Sight object list
            List<Sight> sightList = new List<Sight>();
            sightList.Add(s1);
            sightList.Add(s2);
            sightList.Add(s3);

            // Sight Id list
            List<string> sightIdList1 = new List<string>();
            sightIdList1.Add(s1.Id);
            sightIdList1.Add(s2.Id);
            // Another list for another customer
            List<string> sightIdList2 = new List<string>();
            sightIdList2.Add(s2.Id);
            sightIdList2.Add(s3.Id);

            // Initiate customers
            Customer c1 = new Customer("1", "John", sightIdList1);
            Customer c2 = new Customer("2", "Mac", sightIdList2);

            // Create customers list
            List<Customer> customerList = new List<Customer>();
            customerList.Add(c1);
            customerList.Add(c2);

            // Create estate
            Estate newEstate = new Estate("Big house", "0123", "65100 Beverly Hills", customerList, sightList);
            // Output newEstate
            Console.WriteLine(newEstate.ToString());

            // Test search sight
            Console.Write("Search sight id: ");
            string sight_id = Console.ReadLine();
            string result = newEstate.findSight(sight_id);
            if (result.Equals(""))
                Console.WriteLine("Can't find!");
            else
                Console.WriteLine(result);

            // Test search customer id
            Console.Write("Search customer id: ");
            string customer_id = Console.ReadLine();
            result = newEstate.findCustomerId(customer_id);
            if (result.Equals(""))
                Console.WriteLine("Can't find!");
            else
                Console.WriteLine(result);

            // Test search customer name
            Console.Write("Search customer name: ");
            string customer_name = Console.ReadLine();
            result = newEstate.findCustomerName(customer_name);
            if (result.Equals(""))
                Console.WriteLine("Can't find!");
            else
                Console.WriteLine(result);

        }
    }
}
