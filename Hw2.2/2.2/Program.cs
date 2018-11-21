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

            string text;
            TextAnalyzer textAnalyzer = new TextAnalyzer(out text);
            SortedList<char, int>  sortedList = textAnalyzer.GetCharList();

            Console.WriteLine(textAnalyzer.getText());
            foreach (var c in sortedList) {
                Console.WriteLine("Char " + c.Key + " appears " + c.Value + " times.");
            }
        }
    }
}
