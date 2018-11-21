using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class TextAnalyzer
    {
        private string text;
     
        public TextAnalyzer(out string text) {
            initialize(out text);
            this.text = text;
        }

        public void initialize(out string uninit_text) {
            uninit_text = "";
            // create builder so we can append the characters
            // builder will contain the return value and the information
            StringBuilder builder = new StringBuilder();
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();
            // Add the random characters to builder
            for (int i=1; i <= 50; i++) {
                int num = rand.Next(0, chars.Length - 1);
                builder.Append(chars[num]);
            }

            // Sort the builder and convert it back to string
            char[] characters = builder.ToString().ToArray();
            Array.Sort(characters);
            uninit_text = new string(characters);
        }

        public string getText() {
            return this.text;
        }

        public SortedList<char, int> GetCharList() {

           SortedList<char, int> charList= new SortedList<char, int>();

           foreach (char c in this.text) {
                if (charList.ContainsKey(c))
                    charList[c]++;
                else
                    charList[c] = 1;
           }

            return charList;
        }

    }
}
