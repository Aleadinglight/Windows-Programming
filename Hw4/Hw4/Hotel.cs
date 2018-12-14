using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Hw4
{
    [XmlRoot("Hotel"), Serializable]
    class Hotel : ReadWriteInterface
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
            WriteBinary(w);
            w.Close();
        }

        public void Read(string filePath)
        {
            var r = new BinaryReader(new FileStream(filePath, FileMode.Open));
            ReadBinary(r);
            r.Close();
        }

        public void WriteBinary(BinaryWriter r)
        {
            try
            {
                r.Write(name);
                r.Write(constructionDate);
                r.Write(address);
                r.Write(stars);
                r.Write(roomList.Count);
                foreach (var room in roomList)
                {
                    room.WriteBinary(r);
                }
                r.Write(this.customerList.Count);
                foreach (var customer in customerList)
                {
                    customer.WriteBinary(r);
                }
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
        }
    }
}
