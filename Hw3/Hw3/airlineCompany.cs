using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    public class airlineCompany
    {
        private readonly string companyName;
        List<Flight> flightList;

        // Constructor
        public airlineCompany(string name)
        {
            this.companyName = name;
            this.flightList = new List<Flight>();
        }

        public override string ToString()
        {
            return this.companyName;
        }
       
        // Define indexer
        public Flight this[int index]
        {
            get
            {
                return this.flightList.ElementAt(index);
            }
            set
            {
                this.flightList.Insert(index, value);
            }
        }

        public int flightCount()
        {
            return this.flightList.Count();
        }

        public string findFlight(string flightID)
        {
            string ret = "";
            for (int i = 0; i < this.flightList.Count(); i++)
            {
                ret += this.flightList.ElementAt(i).findFlight(flightID);
            }
            return ret;
        }

        public string applyDelegate(processFlight processDelegate, double price)
        {
            string res="";
            foreach (Flight f in this.flightList)
            {
                if (f.Price > price)
                    res += processDelegate(f);
            }
            return res;
        }
    }
}
