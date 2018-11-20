using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextAnalyzer a = new TextAnalyzer("Hello");
            string b = "asd";
            b = a.initialize(b);
            Console.WriteLine(b);
        }
    }
}
