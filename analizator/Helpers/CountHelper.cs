﻿using analizator.WorkSpace;
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
            CountLetters();
            CountWords();
            CountPunctuationMarks();
            CountSentences();
        }

        #region Count Methods
        private void CountLetters()
        {
            //Student A
            // WorkSpaceItemCollection.CountLetters
        }

        private void CountWords()
        {
            WorkSpaceItemCollection.CountWords = content.Count(char.IsWhiteSpace) + 1;
            /* This can be copy to main
             * Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine($"{Environment.NewLine}This story has {WorkSpaceItemCollection.CountWords} words!");
               Console.ForegroundColor = ConsoleColor.White;
            */
        }

        private void CountPunctuationMarks()
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

            Console.WriteLine("Number of punctuation marks: " + count);
               
            // WorkSpaceItemCollection.CountPunctuationMarks
        }

        private void CountSentences()
        {
            // Student C

            string[] sentences = content.Split('.');

            Console.WriteLine("Number of sentences: " + sentences.Length);

            //WorkSpaceItemCollection.CountSentences
        }
        #endregion
    }
}
