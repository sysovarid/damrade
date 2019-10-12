using analizator.WorkSpace;
using System;
using System.IO;

namespace analizator.Helpers
{
    public class RaportHelper
    {
        public void GenerateReport()
        {
            Console.WriteLine("Wszystkie litery: \n");

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

            Console.WriteLine("Samogłoski: \n");

            foreach (var i in WorkSpaceItemCollection.VolwesCharts)
            {
                Console.WriteLine($"{i.Key} : {i.Value}");
            }

            Console.WriteLine("Spółgłoski: \n");
            foreach (var i in WorkSpaceItemCollection.ConsonantCharts)
            {
                Console.WriteLine($"{i.Key} : {i.Value}");
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

                foreach (var item in WorkSpaceItemCollection.VolwesCharts)
                {
                    streamWriter.WriteLine($"Samogłoska {item.Key} = {item.Value}");
                }

                foreach (var item in WorkSpaceItemCollection.ConsonantCharts)
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
