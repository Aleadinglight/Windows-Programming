using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hw2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable storage = new Hashtable();
            storage.Add("Chopin", new Concert("Chopin", "Vaasa", "12/1", "14:30", 100.0));
            storage.Add("Beethoven", new Concert("Beethoven", "Vaasa", "12/1", "14:30", 90.0));
            storage.Add("Mozart", new Concert("Mozart", "Vaasa", "12/1", "14:30", 80.0));
            storage.Add("Handel", new Concert("Handel", "Vaasa", "12/1", "14:30", 70.0));
            storage.Add("Bach", new Concert("Bach", "Vaasa", "12/1", "14:30", 60.0));
            
            
            Concert c = (Concert)storage["Mozart"];
            
            // Operator ++
            Concert Mozart = (Concert) storage["Mozart"];
            Mozart++;
            Concert Chopin = (Concert)storage["Chopin"];


            // Operator <
            if (Mozart > Chopin)
                Console.WriteLine("The Mozart concert is more expensive than Chopin");
            else
                Console.WriteLine("The Chopin concert is more expensive than Mozart");

            // Print out
            foreach (DictionaryEntry item in storage)
            {
                Console.WriteLine(item.Key + "   -   " + ((Concert)item.Value).toString());
            }


        }
    }
}
