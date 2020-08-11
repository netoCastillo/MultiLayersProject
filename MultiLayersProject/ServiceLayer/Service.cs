using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    
    public class Service
    {
        private static string  url = "https://jsonplaceholder.typicode.com/posts";
        public static string GetPost()
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            using (var stream = new StreamReader(response.GetResponseStream()))
            {
                return stream.ReadToEnd();

            }
        }
    }
}
