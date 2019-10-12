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

        public WebClient client { get; set; }

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
            }

            catch (WebException e)
            {
                throw new  Exception ($"Something went wrong! Message: {e.Message}");
            }

        }
        public void GetAllContentFromLocal()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader($"{Directory.GetCurrentDirectory()}//{connectionPath}"))
                {
                    WorkSpaceItemCollection.WebsiteContent = sr.ReadToEnd();                    
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
