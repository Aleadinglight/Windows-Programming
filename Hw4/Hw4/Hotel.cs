using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hw4
{
    class Hotel : ReadWriteInterface
    {
        private string name, constructionDate, address;
        private int stars;
        private List<Room> roomList;
        private List<Customer> customerList;

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

        public Hotel(string name, string constructDate, string address, int stars)
        {
            this.name = name;
            this.constructionDate = constructDate;
            this.address = address;
            this.stars = stars;
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
                r.Write(customers.Count);
                foreach (var customer in customers)
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
                    AddRoom(room);
                }
                int customersCount = r.ReadInt32();
                for (var i = 0; i < customersCount; i++)
                {
                    var customer = new Customer();
                    customer.ReadBinary(r);
                    AddCustomer(customer);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
            }
        }
    }
}
