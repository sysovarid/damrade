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
        private string connectionPath { get; set; }

        private WebClient client { get; set; }

        public WebHelper()
        {
            connectionPath = ConfigurationManager.AppSettings["address"];
            client = new WebClient();
            GetAllContentToList();
        }

        private void GetAllContentToList()
        {
            try
            {
               WorkSpaceItemCollection.WebsiteContent = Client.DownloadString(ConnectionPath);
            }

            catch (WebException e)
            {
                throw new  Exception ($"Somethink went wrong! Message: {e.Message}");
            }

        }
    }
}
