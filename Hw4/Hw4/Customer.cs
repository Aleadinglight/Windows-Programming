using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    class Customer
    {
        string name, address, arrivalDate;
        int roomNumber, stayDuration;

        public Customer(string name, string address, string arrivalDate, int roomNumber, int stayDuration)
        {
            this.name = name;
            this.address = address;
            this.arrivalDate = arrivalDate;
            this.roomNumber = roomNumber;
            this.stayDuration = stayDuration;
        }
    }
}
