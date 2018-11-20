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
     
        public TextAnalyzer(string text) {
            this.text = text;
        }

        public string initialize(string uninit_text) {
            uninit_text = "";
            // builder will contain the return value and the information
            StringBuilder builder = new StringBuilder();
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();

            for (int i=1; i <= 50; i++) {
                int num = rand.Next(0, chars.Length - 1);
                builder.Append(chars[num]);
            }
            
            char[] characters = builder.ToString().ToArray();
            Array.Sort(characters);
            builder.Clear();
            builder.Append(new string(characters));

            for (int i = 0; i < chars.Length; i++) {
                int count = uninit_text.Count(x => x==chars[i]);
                builder.Append("\nCharacter " +chars[i]+" appears "+count+" times");
            }
            uninit_text = builder.ToString();
            return uninit_text;
        }
    }
}
