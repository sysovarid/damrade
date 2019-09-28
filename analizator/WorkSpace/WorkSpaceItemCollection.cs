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
        #endregion
    }
}
