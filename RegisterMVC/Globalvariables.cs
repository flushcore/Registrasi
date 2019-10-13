using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace RegisterMVC
{
    public class Globalvariables
    {
        public static HttpClient WebAPIClient = new HttpClient();

        static Globalvariables()
        {
            WebAPIClient.BaseAddress = new Uri("http://localhost:64715/api/");
            WebAPIClient.DefaultRequestHeaders.Clear();
            WebAPIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}