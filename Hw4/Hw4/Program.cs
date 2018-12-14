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

            // Create hotel
            Hotel myHotel = new Hotel("California", "30/1/1998", "1st Sad Street", 5);
        }
    }
}
