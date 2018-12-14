using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment4 {
    [XmlType("Room"), Serializable]
    public class Room : IRoom{
        private string number;
        [XmlElement("Number")]
        public string Id {
            get {
                return this.number;
            }
            set {
                this.number = value;
            }
        }

        private double area;
        [XmlElement("Area")]
        public double Area {
            get {
                return this.area;
            }
            set {
                this.area = value;
            }
        }

        private string type;
        [XmlElement("Type")]
        public string Type {
            get {
                return this.type;
            }
            set {
                this.type = value;
            }
        }

        private double price;
        [XmlElement("Price")]
        public double Price {
            get {
                return this.price;
            }
            set {
                this.price = value;
            }
        }

        private string description;
        [XmlElement("Description")]
        public string Description {
            get {
                return this.description;
            }
            set {
                this.description = value;
            }
        }

        public Room(string number, double area, string type, double price, string description) {
            this.number = number;
            this.area = area;
            this.type = type;
            this.price = price;
            this.description = description;
        }
        public Room() {
            this.number = "";
            this.area = 0;
            this.type = "";
            this.price = 0;
            this.description = "";
        }
        public override string ToString() {
            string res = "";
            res += "Number: " + this.Id + "\n";
            res += "Area: " + this.Area+ "\n";
            res += "Type: " + this.Type+ "\n";
            res += "Price: " + this.Price+ "\n";
            res += "Description: " + this.Description + "\n";
            return res;
        }


        public void WriteBinary(BinaryWriter w) {
            try {
                w.Write(number);
                w.Write(area);
                w.Write(type);
                w.Write(price);
                w.Write(description);
            } catch (Exception e) {
                Console.WriteLine(e.Message + "\n");
            }
        }
        public void ReadBinary(BinaryReader r) {
            try {
                number = r.ReadString();
                area = r.ReadDouble();
                type = r.ReadString();
                price = r.ReadDouble();
                description = r.ReadString();
            } catch (Exception e) {
                Console.WriteLine(e.Message + "\n");
            }
        }
    }
}
