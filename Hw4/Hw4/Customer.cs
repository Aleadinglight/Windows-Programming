using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hw4
{
    class Customer : ReadWriteInterface
    {
        string name, address, arrivalDate, roomNumber;
        int stayDuration;

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
