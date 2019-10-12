using analizator.WorkSpace;
using System;
using System.Linq;

namespace analizator.Helpers
{
    public class CountHelper
    {
        private string content;

        public CountHelper()
        {
            content = WorkSpaceItemCollection.WebsiteContent;
            
        }

        #region Count Methods
        public void CountLetters()
        {
            //Student A
            WorkSpaceItemCollection.CountLetters = content.Count(char.IsLetter);
        }

        public void CountWords()
        {
            string[] words = content.Split(' ');

            int counter = 0;

            foreach(string w in words)
            {
                if(w.Length > 1)
                {
                    counter++;
                }
            }

            WorkSpaceItemCollection.CountWords = counter;
        }

        public void CountPunctuationMarks()
        {

            //Student C

            int count = 0;
            foreach (char c in content) { 
            if (c == '.' || c == ',' || c == ';' || c == ':' || c == '?'
                || c == '!' || c == '(' || c == ')'
                || c == '"' || c == '-')
            {
                count++;
            }
        }


            //Console.WriteLine("Number of punctuation marks: " + count);

            WorkSpaceItemCollection.CountPunctuationMarks = count;
        }

        public void CountSentences()
        {
            // Student C

            string[] sentences = content.Split('.');

            //Console.WriteLine("Number of sentences: " + sentences.Length);

            WorkSpaceItemCollection.CountSentences = sentences.Length;
        }
        #endregion
    }
}
