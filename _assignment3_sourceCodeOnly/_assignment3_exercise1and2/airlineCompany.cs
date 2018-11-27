using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1601140_assignment3
{
    public class airlineCompany
    {
        //attributes
        private readonly string companyName;
        List<flight> flightList;
        /*--------------------------------------------------------*/

        // constructor
        public airlineCompany(string inName)
        {
            this.companyName = inName;
            this.flightList = new List<flight>();
        }
        /*--------------------------------------------------------*/

        //methods
        public override string ToString()
        {
            return this.companyName;
        }
        //indexer
        public flight this[int index]
        {
            get
            {
                return this.flightList.ElementAt(index);
            }
        }
        public void addNewFlight(string inFlightID, string inOrigin, string inDestination, string inDate, double inPrice)
        {
            this.flightList.Add(new flight(inFlightID, inOrigin, inDestination, inDate, inPrice));
        }
        public int numberOfFlight()
        {
            return this.flightList.Count();
        }
        public flight findFlight(string ID)
        {
            for (int i = 0; i < this.flightList.Count(); i++)
            {
                if (this[i].FlightID.Equals(ID))
                    return this[i];
            }
            return null;
        }

        public string processCheapFlight(processFlight processDelegate, double inPrice)
        {
            string res="";
            foreach (flight f in this.flightList)
            {
                if (f.Price < inPrice)
                    res += processDelegate(f);
            }
            return res;
        }
    }
}
