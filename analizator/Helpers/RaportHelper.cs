using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analizator.Helpers
{
    public class RaportHelper
    {      

        public void GenerateReport()
        {
            //Student A
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
        }

        public void DeleteStatistics()
        {
            //Student B
        }
    }
}
