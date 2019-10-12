using analizator.WorkSpace;
using System;
using System.Configuration;
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
            GetAllContentToList();
        }
        
        public void GetAllContentToList()
        {
            try
            {
               WorkSpaceItemCollection.WebsiteContent = client.DownloadString(connectionPath);
            }

            catch (WebException e)
            {
                throw new  Exception ($"Something went wrong! Message: {e.Message}");
            }

        }
    }
}
