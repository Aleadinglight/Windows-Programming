using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4 {
    class Program {
        static void Main(string[] args) {
            var r1 = new Room("R1", 68.4, "single", 120, "Economy class");
            var r2 = new Room("R2", 93.2, "double", 1269, "High class");
            var r3 = new Room("R3", 11, "single", 120, "Economy class");
            var r4 = new Room("R4", 44, "double", 1269, "High class");

            var c1 = new Customer("C1", "1st Wall Street", "R1", "01/01/2018", 1);
            var c2 = new Customer("C2", "221 Baker Street", "R2", "02/01/2018", 2);
            var c3 = new Customer("C3", "Vourikatu 14", "R2", "03/01/2018", 3);

            var hotel = new Hotel("Clarion Hotel", "23/07/1932", "31 Wolffintie", 4);
            hotel.AddRoom(r1);
            hotel.AddRoom(r2);
            hotel.AddRoom(r3);
            hotel.AddRoom(r4);
            hotel.AddCustomer(c1);
            hotel.AddCustomer(c2);
            hotel.AddCustomer(c3);

            // Using binary reader / writer
            Console.Clear();
            hotel.Write("./hotel.bin2");
            var h0 = new Hotel();
            h0.Read("./hotel.bin2");
            Console.WriteLine(h0);
            Console.ReadLine();

            // Using binary formatter
            Console.Clear();
            FileDumper<Hotel>.WriteBinary(hotel, "./hotel.bin");
            var h1 = FileDumper<Hotel>.ReadBinary("./hotel.bin");
            Console.WriteLine(h1);
            Console.ReadLine();

            // Using XML
            Console.Clear();
            FileDumper<Hotel>.WriteXML(hotel, "./hotel.xml");
            var h2 = FileDumper<Hotel>.ReadXML("./hotel.xml");
            Console.WriteLine(h2);
            Console.ReadLine();

            // Using JSON
            Console.Clear();
            FileDumper<Hotel>.WriteJSON(hotel, "./hotel.json");
            var h3 = FileDumper<Hotel>.ReadJSON("./hotel.json");
            Console.WriteLine(h3);
            Console.ReadLine();
        }
    }
}
