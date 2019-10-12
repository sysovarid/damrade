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
            WorkSpaceItemCollection.CountWords = content.Count(char.IsWhiteSpace) + 1;
        }

        public void CountPunctuationMarks()
        {

            //Student C

            int count = 0;
            foreach (char c in content)
            {
                if (c == '.' || c == '?')
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
