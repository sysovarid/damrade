using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analizator.Helpers
{
    public class CountHelper
    {
        private string content {get; set;}

        public CountHelper(string Content)
        {
            content = Content;
        }

        public void CountLetters()
        {
            //Student A
        }

        public void CountWords()
        {

            int output = content.Count(char.IsWhiteSpace) + 1;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Environment.NewLine}This story has {output} words!");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void CountPunctuationMarks()
        {
            //Student C
        }

        public void CountSentences()
        {
            // Student C
        }
    }
}
