using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    class Hotel
    {
        private string name, constructDate, address;
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
                return this.constructDate;
            }
            set
            {
                this.constructDate = value;
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
            this.constructDate = constructDate;
            this.address = address;
            this.stars = stars;
        }

        public Hotel(string name, string constructDate, string address, int stars, List<Room> roomList, List<Customer> customerList)
        {
            this.name = name;
            this.constructDate = constructDate;
            this.address = address;
            this.stars = stars;
            this.roomList = roomList;
            this.customerList = customerList;
        }

        public void saveHotelData()
        {

        }
    }
}
