using analizator.WorkSpace;
using System;
using System.Configuration;
using System.IO;
using System.Net;

namespace analizator.Helpers
{
    /*
     *  To download content from website we need only to create constructor!
     *   How easy it is!
     */
    public class WebHelper
    {
        public string connectionPath { get; set; }

        public bool IsValidPath { get; set; }

        private WebClient client { get; set; }

        public WebHelper()
        {
            connectionPath = "https://s3.zylowski.net/public/input/6.txt";
            client = new WebClient();     
        }
        
        public void GetAllContentToList()
        {
            try
            {
               WorkSpaceItemCollection.WebsiteContent = client.DownloadString(connectionPath).ToUpper();
               IsValidPath = true;
            }

            catch (WebException e)
            {
                Console.WriteLine($"Taka ścieżka nie istnieje {connectionPath}");
                IsValidPath = false;
            }

        }
        public void GetAllContentFromLocal()
        {
            try
            {
                using (StreamReader sr = new StreamReader($"{Directory.GetCurrentDirectory()}//{connectionPath}.txt"))
                {
                    WorkSpaceItemCollection.WebsiteContent = sr.ReadToEnd();
                    IsValidPath = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Taka ścieżka pliku nie istnieje {connectionPath}:");
                IsValidPath = false;
            }
        }
    }
}
