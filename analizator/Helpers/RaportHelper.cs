using analizator.WorkSpace;
using System;
using System.Collections.Generic;
using System.IO;
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
        }

        public void DeleteStatistics()
        {
            string directory = Directory.GetCurrentDirectory();

            File.Delete($"{directory}//statystyki.txt");
        }
    }
}
