using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2._1
{
    class Concert
    {
        // title, location, date, time and price. 
        private string _title;
        private string _location;
        private string _date;
        private string _time;
        private double _price;

        Concert(string title, string location, string date, string time, double price)
        {
            this._title = title;
            this._location = location;
            this._date = date;
            this._time = time;
            this._price = price;
        }

        public static Concert operator ++ (Concert a)
        {
            a.Price+=5;
            return a;
        }

        public static Concert operator --(Concert a)
        {
            a.Price -= 5;
            return a;
        }

        public static bool operator< (Concert b, Concert c)
        {
            if (b.Price < c.Price)
                return true;
            return false;
        }

        public static bool operator> (Concert b, Concert c)
        {
            if (b.Price > c.Price)
                return true;
            return false;
        }

        public string toString()
        {
            return "Title: " + this._title + "\nLocation: " + this._location + "\nDate: " + this._date + "\nTime: " + this._time + "\nPrice: " + this._price;
        }

        public string Location {
            get
            {
                return this._location;
            }
            set
            {
                this._location = value;
            }
        }

        public string Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }

        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }

        public string Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }

        public double Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
            }
        }
    }
}
