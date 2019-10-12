using analizator.WorkSpace;
using System;
using System.IO;

namespace analizator.Helpers
{
    public class RaportHelper
    {      

        public void GenerateReport()
        {
        }

        public void SaveStatistics()
        {
            using (StreamWriter streamWriter = new StreamWriter("statystyki.txt"))
            {
                streamWriter.WriteLine($" Liczba liter: {WorkSpaceItemCollection.CountLetters}");
                streamWriter.WriteLine($" Liczba wyrazów: {WorkSpaceItemCollection.CountWords}");
                streamWriter.WriteLine($" Liczba znaków: {WorkSpaceItemCollection.CountPunctuationMarks}");
                streamWriter.WriteLine($" Liczba zdań: {WorkSpaceItemCollection.CountSentences}");
            }
        {         
        }

        public void DeleteStatistics()
        {
            string directory = Directory.GetCurrentDirectory();

            File.Delete($"{directory}//statystyki.txt");
        }
    }
}
