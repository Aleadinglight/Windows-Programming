using System;
using System.IO;
using System.Xml.Serialization;

namespace Assignment4 {
    [XmlType("Customer"), Serializable]
    public class Customer : ICustomer {
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

        private string roomId;
        [XmlElement("Room")]
        public string RoomId {
            get {
                return this.roomId;
            }
            set {
                this.roomId = value;
            }
        }

        private string arrivalDate;
        [XmlElement("ArrivalDate")]
        public string ArrivalDate {
            get {
                return this.arrivalDate;
            }
            set {
                this.arrivalDate = value;
            }
        }

        private int lengthOfStay;
        [XmlElement("LengthOfStay")]
        public int LengthOfStay {
            get {
                return this.lengthOfStay;
            }
            set {
                this.lengthOfStay = value;
            }
        }

        public Customer(string name, string address, string roomId, string arrivalDate, int lengthOfStay) {
            this.name = name;
            this.address = address;
            this.roomId = roomId;
            this.arrivalDate = arrivalDate;
            this.lengthOfStay = lengthOfStay;
        }
        public Customer() {
            this.name = "";
            this.address = "";
            this.roomId = "";
            this.arrivalDate = "";
            this.lengthOfStay = 0;
        }

        public override string ToString() {
            string res = "";
            res+= "Name: " + this.Id + "\n";
            res += "Address: " + this.Address + "\n";
            res += "Room: " + this.RoomId + "\n";
            res += "Arrival date: " + this.ArrivalDate + "\n";
            res += "Length of stay: " + this.LengthOfStay + "\n";
            return res;
        }


        public void WriteBinary(BinaryWriter w) {
            try {
                w.Write(name);
                w.Write(address);
                w.Write(roomId);
                w.Write(arrivalDate);
                w.Write(lengthOfStay);
            } catch (Exception e) {
                Console.WriteLine(e.Message + "\n");
            }
        }
        public void ReadBinary(BinaryReader r) {
            try {
                name = r.ReadString();
                address = r.ReadString();
                roomId = r.ReadString();
                arrivalDate = r.ReadString();
                lengthOfStay = r.ReadInt32();
            } catch (Exception e) {
                Console.WriteLine(e.Message + "\n");
            }
        }
    }
}
