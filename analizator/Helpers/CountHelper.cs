using analizator.WorkSpace;
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
            // WorkSpaceItemCollection.CountPunctuationMarks
        }

        private void CountSentences()
        {
            // Student C
            //WorkSpaceItemCollection.CountSentences
        }
        #endregion
    }
}
