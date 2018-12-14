using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4 {
    public interface IBase {
        string Id { get; set; }
        void WriteBinary(BinaryWriter w);
        void ReadBinary(BinaryReader r);
        string 	();
    }

    public interface IHotel : IBase {
        /*Properties of interfaces*/
        string ConstructionDate { get; set; }
        string Address { get; set; }
        int Stars { get; set; }
        //List<ICustomer> Customers { get; set; }
        //List<IRoom> Rooms { get; set; }

        //void AddCustomer(ICustomer customer);
        //void AddRoom(IRoom room);

        //ICustomer GetCustomer(string Id);
        //IRoom GetRoom(string Id);
    }
    public interface IRoom : IBase {
        /*Properties of interfaces*/
        double Area { get; set; }
        string Type { get; set; }
        double Price{ get; set; }
        string Description{ get; set; }
    }
    public interface ICustomer : IBase {
        string Address { get; set; }
        string RoomId { get; set; }
        string ArrivalDate { get; set; }
        int LengthOfStay { get; set; }
    }
}
