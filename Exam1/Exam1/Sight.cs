using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Sight
    {
        private string id, constructionDate, address;
        private double area, price;

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
        public string ConstructDate
        {
            get
            {
                return this.constructionDate;
            }
            set
            {
                this.constructionDate = value;
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
        public double Area
        {
            get
            {
                return this.area;
            }
            set
            {
                this.area = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public Sight(string id, string constructionDate, string address, double area, double price)
        {
            this.id = id;
            this.constructionDate = constructionDate;
            this.address = address;
            this.area = area;
            this.price = price;
        }

        public override string ToString()
        {
            return "Sight id: " + this.id
                    +"\nAddress: "+ this.address
                    +"\nArea: "+ this.area
                    +"\nPrice: "+ this.price
                    +"\nConstruction Date: "+this.constructionDate+"\n";
        }

        public string findSight(string inSightId)
        {
            if (inSightId.Equals(this.id))
            {
                return this.ToString();
            }
            return "";
        }
    }
}
