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
        }

        public void DeleteStatistics()
        {
            string directory = Directory.GetCurrentDirectory();

            File.Delete($"{directory}//statystyki.txt");
        }
    }
}
