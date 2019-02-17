using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Estate
    {
        private string name, phoneNumber, address;
        
        private List<Customer> customerList;
        private List<Sight> sightList;
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
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
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
        public List<Sight> SightList
        {
            get
            {
                return this.sightList;
            }
            set
            {
                this.sightList = value;
            }
        }

        public Estate(string name, string phoneNumber, string address, List<Customer> customerList, List<Sight> sightList)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.customerList = customerList;
            this.sightList = sightList;
        }


        public override string ToString()
        {
            string ret = "";
            ret += "Name: " + name
                + "\nphoneNumber: " + phoneNumber
                + "\naddress: " + address;
            ret += "\n\nCustomers:\n\n-------------------\n";
            foreach (var c in customerList)
            {
                ret += c.ToString()+"-------------------\n";
            }
            ret += "\n\nSights:\n\n-------------------\n";
            foreach (var s in sightList)
            {
                ret += s.ToString() + "-------------------\n";
            }
            return ret;
        }

        public string findSight(string sightId)
        {
            string ret = "";
            foreach (Sight s in sightList)
            {
                ret+= s.findSight(sightId);
            }
            return ret;
        }

        public string findCustomerId(string inCustomerId)
        {
            string ret = "";
            foreach (Customer c in customerList)
            {
                ret += c.findCustomerId(inCustomerId);
            }
            return ret;
        }

        public string findCustomerName(string inCustomerName)
        {
            string ret = "";
            foreach (Customer c in customerList)
            {
                ret += c.findCustomerName(inCustomerName);
            }
            return ret;
        }
    }
}
