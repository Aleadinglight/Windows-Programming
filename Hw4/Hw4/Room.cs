using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hw4
{
    class Room : ReadWriteInterface
    {
        private int area;
        private string roomNumber, type, description;
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

        public Room(string roomNumber, int area, string type, double price, string description)
        {
            this.roomNumber = roomNumber;
            this.area = area;
            this.type = type;
            this.price = price;
            this.description = description;
        }

        public void WriteBinary(BinaryWriter w)
        {
            try
            {
                w.Write(roomNumber);
                w.Write(area);
                w.Write(type);
                w.Write(price);
                w.Write(description);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
            }
        }

        public void ReadBinary(BinaryReader r)
        {
            try
            {
                roomNumber = r.ReadString();
                area = r.ReadInt32();
                type = r.ReadString();
                price = r.ReadDouble();
                description = r.ReadString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
            }
        }
    }
}
