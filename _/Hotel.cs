using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment4 {
    [XmlRoot("Hotel"), Serializable]
    public class Hotel : IHotel {
        private string name;
        [XmlElement("Name")]
        public string Id {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }

        private string constructionDate;
        [XmlElement("ConstructionDate")]
        public string ConstructionDate {
            get {
                return this.constructionDate;
            }
            set {
                this.constructionDate = value;
            }
        }

        private string address;
        [XmlElement("Address")]
        public string Address {
            get {
                return this.address;
            }
            set {
                this.address = value;
            }
        }

        private int stars;
        [XmlElement("Stars")]
        public int Stars {
            get {
                return this.stars;
            }
            set {
                this.stars = value;
            }
        }

        private List<Customer> customers;
        [XmlArray("CustomerList"), XmlArrayItem("Customer")]
        public List<Customer> Customers {
            get {
                return this.customers;
            }
            set {
                this.customers = value;
            }
        }

        private List<Room> rooms;
        [XmlArray("RoomList"), XmlArrayItem("Room")]
        public List<Room> Rooms {
            get {
                return this.rooms;
            }
            set {
                this.rooms = value;
            }
        }

        public Hotel(string name, string constructionDate, string address, int stars) {
            this.name = name;
            this.constructionDate = constructionDate;
            this.address = address;
            this.stars = stars;
            this.customers = new List<Customer>();
            this.rooms = new List<Room>();
        }
        public Hotel() {
            this.name = "";
            this.constructionDate = "";
            this.address = "";
            this.stars = 0;
            this.customers = new List<Customer>();
            this.rooms = new List<Room>();
        }

        public void AddRoom(Room room) {
            this.rooms.Add(room);
        }
        public void AddCustomer(Customer customer) {
            this.customers.Add(customer);
        }


        public Customer GetCustomer(string Id) {
            foreach(var customer in Customers) {
                if (customer.Id.Equals(Id)) {
                    return customer;
                }
            }
            return null;
        }

        public Room GetRoom(string Id) {
            foreach (var room in Rooms) {
                if (room.Id.Equals(Id)) {
                    return room;
                }
            }
            return null;
        }

        public override string ToString() {
            string res = "";
            res += "Name: " + this.Id + "\n";
            res += "Construction date: " + this.ConstructionDate+ "\n";
            res += "Address: " + this.Address+ "\n";
            res += "Stars: " + this.Stars+ "\n";

            res += "---------\n";
            res += "Rooms:\n";
            var rooms = Rooms;
            foreach (var room in rooms) {
                res += "---\n";
                res += room.ToString() + "\n";
            }

            res += "---------\n";
            res += "Customers:\n";
            var customers = Customers;
            foreach (var customer in customers) {
                res += "---\n";
                res += customer.ToString() + "\n";
            }
            return res;
        }

        public void WriteBinary(BinaryWriter r) {
            try {
                r.Write(name);
                r.Write(constructionDate);
                r.Write(address);
                r.Write(stars);
                r.Write(rooms.Count);
                foreach (var room in rooms) {
                    room.WriteBinary(r);
                }
                r.Write(customers.Count);
                foreach(var customer in customers) {
                    customer.WriteBinary(r);
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message + "\n");
            }
        }
        public void ReadBinary(BinaryReader r) {
            try {
                name = r.ReadString();
                constructionDate = r.ReadString();
                address = r.ReadString();
                stars = r.ReadInt32();
                int roomsCount = r.ReadInt32();
                for (var i = 0; i < roomsCount; i++) {
                    var room = new Room();
                    room.ReadBinary(r);
                    AddRoom(room);
                }
                int customersCount = r.ReadInt32();
                for (var i = 0; i < customersCount; i++) {
                    var customer = new Customer();
                    customer.ReadBinary(r);
                    AddCustomer(customer);
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message + "\n");
            }
        }
        public void Write(string filePath) {
            var w = new BinaryWriter(new FileStream(filePath, FileMode.OpenOrCreate));
            WriteBinary(w);
            w.Close();
        }
        public void Read(string filePath) {
            var r = new BinaryReader(new FileStream(filePath, FileMode.Open));
            ReadBinary(r);
            r.Close();
        }
    }
}
