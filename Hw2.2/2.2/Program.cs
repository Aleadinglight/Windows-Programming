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
            string unit_string = "asd";
            string count_result = a.initialize(out unit_string);

            Console.WriteLine(unit_string);
            Console.WriteLine(count_result);
        }
    }
}
