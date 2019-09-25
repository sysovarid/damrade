using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace analizator.Helpers
{
    public class WebHelper
    {
        private string ConnectionPath { get; set; }

        private string Content { get; set; }

        private WebClient Client { get; set; }

        public WebHelper()
        {
            ConnectionPath = ConfigurationManager.AppSettings["address"];
            Client = new WebClient();
        }

        public string GetAllContentToList()
        {
            try
            {

               Content = Client.DownloadString(ConnectionPath);
               return Content;

            }
            catch (WebException e)
            {
                return $"Somethink went wrong! Message: {e.Message}";
            }

        }
    }
}
