using System.Collections.Generic;

namespace analizator.WorkSpace
{
    public static class WorkSpaceItemCollection
    {
        public static string WebsiteContent { get; set; }

        #region Variables needed to report
        public static int CountLetters { get; set; }

        public static int CountWords { get; set; }

        public static int CountPunctuationMarks { get; set; }

        public static int CountSentences { get; set; }

        public static Dictionary<char, int> Chars { get; set; } = new Dictionary<char, int>();

        public static Dictionary<char, int> volwes = new Dictionary<char, int>();

        public static Dictionary<char, int> consonant = new Dictionary<char, int>();
        #endregion
    }
}
