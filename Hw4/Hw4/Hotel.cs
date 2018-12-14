using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Hw4
{
    interface IHotel : ReadWriteInterface
    {
        string Name
        {
            get;
            set;
        }
        string ConstructDate
        {
            get;
            set;
        }
        string Address
        {
            get;
            set;
        }
        int Stars
        {
            get;
            set;
        }
        List<Room> RoomList
        {
            get;
            set;
        }
        List<Customer> CustomerList
        {
            get;
            set;
        }
    }

    [XmlRoot("Hotel"), Serializable]
    public class Hotel : IHotel
    {
        private string name, constructionDate, address;
        private int stars;
        private List<Room> roomList;
        private List<Customer> customerList;

        [XmlElement("Name")]
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        [XmlElement("ConstructDate")]
        public string ConstructDate
        {
            get
            {
                return this.constructionDate;
            }
            set
            {
                this.constructionDate = value;
            }
        }
        [XmlElement("Address")]
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        [XmlElement("Stars")]
        public int Stars
        {
            get
            {
                return this.stars;
            }
            set
            {
                this.stars = value;
            }
        }
        [XmlArray("CustomerList"), XmlArrayItem("Customer")]
        public List<Customer> CustomerList
        {
            get
            {
                return this.customerList;
            }
            set
            {
                this.customerList = value;
            }
        }
        [XmlArray("RoomList"), XmlArrayItem("Room")]
        public List<Room> RoomList
        {
            get
            {
                return this.roomList;
            }
            set
            {
                this.roomList = value;
            }
        }

        public Hotel()
        {
            this.name = "";
            this.constructionDate = "";
            this.address = "";
            this.stars = 0;
            this.roomList = new List<Room>();
            this.customerList = new List<Customer>();
        }

        public Hotel(string name, string constructDate, string address, int stars)
        {
            this.name = name;
            this.constructionDate = constructDate;
            this.address = address;
            this.stars = stars;
            this.roomList = new List<Room>();
            this.customerList = new List<Customer>();
        }

        public Hotel(string name, string constructDate, string address, int stars, List<Room> roomList, List<Customer> customerList)
        {
            this.name = name;
            this.constructionDate = constructDate;
            this.address = address;
            this.stars = stars;
            this.roomList = roomList;
            this.customerList = customerList;
        }

        public void addRoom(Room room)
        {
            this.roomList.Add(room);
        }

        public void removeRoom(Room room)
        {
            this.roomList.Remove(room);
        }

        public void addCustomer(Customer customer)
        {
            this.customerList.Add(customer);
        }

        public void removeCustomer(Customer customer)
        {
            this.customerList.Remove(customer);
        }

        public void Write(string filePath)
        {
            var w = new BinaryWriter(new FileStream(filePath, FileMode.OpenOrCreate));
            try
            {
                w.Write(name);
                w.Write(constructionDate);
                w.Write(address);
                w.Write(stars);
                w.Write(roomList.Count);
                foreach (var room in roomList)
                {
                    room.WriteBinary(w);
                }
                w.Write(this.customerList.Count);
                foreach (var customer in customerList)
                {
                    customer.WriteBinary(w);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
            }
            w.Close();
        }

        public void Read(string filePath)
        {
            var r = new BinaryReader(new FileStream(filePath, FileMode.Open));
            try
            {
                name = r.ReadString();
                constructionDate = r.ReadString();
                address = r.ReadString();
                stars = r.ReadInt32();
                int roomsCount = r.ReadInt32();
                for (var i = 0; i < roomsCount; i++)
                {
                    var room = new Room();
                    room.ReadBinary(r);
                    addRoom(room);
                }
                int customersCount = r.ReadInt32();
                for (var i = 0; i < customersCount; i++)
                {
                    var customer = new Customer();
                    customer.ReadBinary(r);
                    addCustomer(customer);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
            }
            r.Close();
        }

        public override string ToString()
        {
            string res = "";
            res += "Hotel Name: " + this.name + "\n";
            res += "Construction date: " + this.constructionDate + "\n";
            res += "Address: " + this.address + "\n";
            res += "Stars: " + this.stars + "\n";

            res += "---------\n";
            res += "Rooms list:\n";
            foreach (var room in roomList)
            {
                res += "---\n";
                res += room.ToString() + "\n";
            }
            res += "---------\n";
            res += "Customers list:\n";
            foreach (var customer in customerList)
            {
                res += "---\n";
                res += customer.ToString() + "\n";
            }
            return res;
        }
    }
}
