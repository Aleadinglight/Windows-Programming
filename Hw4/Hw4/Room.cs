using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    class Room : ReadWriteInterface
    {
        private int roomNumber, area;
        private string type, description;
        private double price;

        public int RoomNumber
        {
            get
            {
                return this.roomNumber;
            }
            set
            {
                this.roomNumber = value;
            }
        }
        public int Area
        {
            get
            {
                return this.area;
            }
            set
            {
                this.area = value;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public Room(int roomNumber, int area, string type, double price, string description)
        {
            this.roomNumber = roomNumber;
            this.area = area;
            this.type = type;
            this.price = price;
            this.description = description;
        }
    }
}
