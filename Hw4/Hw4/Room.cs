using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Hw4
{
    interface IRoom : ReadWriteInterface
    {
        string RoomNumber
        {
            get;
            set;
        }
        int Area
        {
            get;
            set;
        }
        string Type
        {
            get;
            set;
        }
        string Description
        {
            get;
            set;
        }
        double Price
        {
            get;
            set;
        }
    }

    [XmlType("Room"), Serializable]
    public class Room : IRoom
    {
        private int area;
        private string roomNumber, type, description;
        private double price;

        [XmlElement("RoomNumber")]
        public string RoomNumber
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
        [XmlElement("Area")]
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
        [XmlElement("Type")]
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
        [XmlElement("Description")]
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
        [XmlElement("Price")]
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

        public Room(){ }

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

        public override string ToString()
        {
            string res = "";
            res += "Room number: " + this.roomNumber + "\n";
            res += "Area: " + this.area + "\n";
            res += "Type: " + this.type + "\n";
            res += "Price: " + this.price + "\n";
            res += "Description: " + this.description + "\n";
            return res;
        }
    }
}
