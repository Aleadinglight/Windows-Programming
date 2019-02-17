using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Customer
    {
        private string name, id;
        private List<string> sightId;

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
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public Customer(string id, string name, List<string> sightId)
        {
            this.name = name;
            this.id = id;
            this.sightId = sightId;
        }

        public override string ToString()
        {
            string ret = "";
            ret += "Customer id: " + this.id
                    + "\nName: " + this.name+"\nSight Id: ";
            foreach(string s_id in sightId)
            {
                ret += s_id+" | ";
            }
            return ret+"\n";
        }

        public string findCustomerId(string inCustomerId)
        {
            if (inCustomerId.Equals(this.id))
            {
                return this.ToString();
            }
            return "";
        }

        public string findCustomerName(string inCustomerName)
        {
            
            if (inCustomerName.Equals(this.name))
            {
                return this.ToString();
            }
            return "";
        }
    }
}
