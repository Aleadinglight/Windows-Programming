using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Hw4
{
    [XmlType("Customer"), Serializable]
    class Customer : ReadWriteInterface
    {
        private string name, address, arrivalDate, roomNumber;
        int stayDuration;
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

        [XmlElement("Room")]
        public string RoomId
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

        [XmlElement("ArrivalDate")]
        public string ArrivalDate
        {
            get
            {
                return this.arrivalDate;
            }
            set
            {
                this.arrivalDate = value;
            }
        }

        [XmlElement("StayDuration")]
        public int StayDuration
        {
            get
            {
                return this.stayDuration;
            }
            set
            {
                this.stayDuration = value;
            }
        }

        public Customer() {}

        public Customer(string name, string address, string arrivalDate, string roomNumber, int stayDuration)
        {
            this.name = name;
            this.address = address;
            this.arrivalDate = arrivalDate;
            this.roomNumber = roomNumber;
            this.stayDuration = stayDuration;
        }

        public void WriteBinary(BinaryWriter w)
        {
            try
            {
                w.Write(name);
                w.Write(address);
                w.Write(roomNumber);
                w.Write(arrivalDate);
                w.Write(stayDuration);
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
                address = r.ReadString();
                roomNumber = r.ReadString();
                arrivalDate = r.ReadString();
                stayDuration = r.ReadInt32();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
            }
        }
    }
}
