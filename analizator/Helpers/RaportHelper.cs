using analizator.WorkSpace;
using System;
using System.IO;

namespace analizator.Helpers
{
    public class RaportHelper
    {

        public void GenerateReport()
        {
            foreach (char ch in WorkSpaceItemCollection.WebsiteContent)
            {
                if (Char.IsLetter(ch))
                {
                    if (WorkSpaceItemCollection.Chars.ContainsKey(ch) == false)
                    {
                        WorkSpaceItemCollection.Chars.Add(ch, 0);
                    }
                    WorkSpaceItemCollection.Chars[ch] += 1;
                }
            }
        }

        public void SaveStatistics()
        {
            using (StreamWriter streamWriter = new StreamWriter("statystyki.txt"))
            {
                streamWriter.WriteLine($" Liczba liter: {WorkSpaceItemCollection.CountLetters}");
                streamWriter.WriteLine($" Liczba wyrazów: {WorkSpaceItemCollection.CountWords}");
                streamWriter.WriteLine($" Liczba znaków: {WorkSpaceItemCollection.CountPunctuationMarks}");
                streamWriter.WriteLine($" Liczba zdań: {WorkSpaceItemCollection.CountSentences}");

                foreach (var item in WorkSpaceItemCollection.volwes)
                {
                    streamWriter.WriteLine($"Samogłoska {item.Key} = {item.Value}");
                }

                foreach (var item in WorkSpaceItemCollection.consonant)
                {
                    streamWriter.WriteLine($"Spółgłoska {item.Key} = {item.Value}");
                }
            }

        }

        public void DeleteStatistics()
        {
            string directory = Directory.GetCurrentDirectory();

            File.Delete($"{directory}//statystyki.txt");
        }
    }
}
