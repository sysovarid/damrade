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

            CountLetters();
            CountWords();
            CountSentences();
            CountPunctuationMarks();
            CountVolvesConsoant();
        }

        #region Count Methods
        private void CountLetters()
        {
            WorkSpaceItemCollection.CountLetters = content.Count(char.IsLetter);
        }

        private void CountWords()
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

        private void CountPunctuationMarks()
        {
            int count = 0;
            foreach (char c in content)
            {
                if (c == '.' || c == '?')
                {
                    count++;
                }
            }

            WorkSpaceItemCollection.CountPunctuationMarks = count;
        }

        private void CountSentences()
        {
            string[] sentences = content.Split('.');
            WorkSpaceItemCollection.CountSentences = sentences.Length;
        }

        private void CountVolvesConsoant()
        {
            foreach (var item in WorkSpaceItemCollection.Chars.OrderBy(x => x.Key))
            {
                if (item.Key == 'A' || item.Key == 'E' || item.Key == 'Y' || item.Key == 'I' || item.Key == 'O'
                    || item.Key == 'Ą' || item.Key == 'Ę' || item.Key == 'U' || item.Key == 'Ó')
                {
                    WorkSpaceItemCollection.VolwesCharts.Add(item.Key, item.Value);
                }
                else
                {
                    WorkSpaceItemCollection.ConsonantCharts.Add(item.Key, item.Value);
                }

            }
        }
        #endregion
    }
}
