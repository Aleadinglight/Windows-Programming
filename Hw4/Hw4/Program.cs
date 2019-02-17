using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiate some rooms
            Room room1 = new Room("1A", 10, "Single", 100.0, "Sad room");
            Room room2 = new Room("2A", 30, "Double", 200.0, "Happy room");
            Room room3 = new Room("1B", 200, "Single", 1000.0, "Big room with piano");
            Room room4 = new Room("2B", 500, "Double", 5000.0, "Rich kid room");

            // Initiate some customers
            var c1 = new Customer("Trump", "Wasington DC", "01/01/2018", "1A", 1);
            var c2 = new Customer("Bush", "Hell", "02/01/2018", "1B", 3);

            // Create hotel
            Hotel myHotel = new Hotel("California", "30/1/1998", "1st Sad Street", 5);
            myHotel.addCustomer(c1);
            myHotel.addCustomer(c2);
            myHotel.addRoom(room1);
            myHotel.addRoom(room2);
            myHotel.addRoom(room3);
            myHotel.addRoom(room4);

            // Using binary reader / writer
            Console.WriteLine("---------------\nSaved as binary\n---------------");
            myHotel.Write("./hotel.txt");
            var readHotelAsBinary = new Hotel();
            readHotelAsBinary.Read("./hotel.txt");
            Console.WriteLine(readHotelAsBinary.ToString());
            Console.ReadLine();

            // Using binary formatter
            Console.WriteLine("--------------------------\nSaved as serialized binary\n--------------------------");
            FileSaver<Hotel>.WriteBinary(myHotel, "./myHotel.bin");
            var readHotelAsSerialized = FileSaver<Hotel>.ReadBinary("./myHotel.bin");
            Console.WriteLine(readHotelAsSerialized);
            Console.ReadLine();

            // Using XML
            Console.WriteLine("------------\nSaved as XML\n------------");
            FileSaver<Hotel>.WriteXML(myHotel, "./myHotel.xml");
            var readHotelAsXml = FileSaver<Hotel>.ReadXML("./myHotel.xml");
            Console.WriteLine(readHotelAsXml);
            Console.ReadLine();

            // Using JSON
            Console.WriteLine("-------------\nSaved as JSON\n-------------");
            FileSaver<Hotel>.WriteJSON(myHotel, "./myHotel.json");
            var readHotelJson = FileSaver<Hotel>.ReadJSON("./myHotel.json");
            Console.WriteLine(readHotelJson);
            Console.ReadLine();
        }
    }
}
