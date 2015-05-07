using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TryingOutStuff
{
    class RestGetCountryInfo
    {
        static void Main(string[] args)
        {
            //HttpResponseMessage httpResponseMessage = GetCountryInfoByCode("IN");
            HttpResponseMessage httpResponseMessage = GetPublicProfilePicUrl("karan");
            Console.WriteLine(httpResponseMessage.ToString());
        }

        private static string GetMashapeKey()
        {
            string mashapeKey = "sSBP29CDyYmsh0q0kRjSkfArmGfQp1gL9RujsniegbbYSXn8rm";
            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["mashapeKey"]))
            {
                mashapeKey = ConfigurationManager.AppSettings["mashapeKey"];
            }
            return mashapeKey;
        }

        private static string GetApiUrl(string api)
        {
            return ConfigurationManager.AppSettings[api];
        }

        public static HttpResponseMessage GetCountryInfoByCode(string code)
        {
            HttpClient httpClient = new HttpClient();
            Uri uri = new Uri("https://restcountries.p.mashape.com/alpha/" + code);
            httpClient.DefaultRequestHeaders.Add("X-Mashape-Key", "sSBP29CDyYmsh0q0kRjSkfArmGfQp1gL9RujsniegbbYSXn8rm");
            HttpResponseMessage httpResponseMessage = httpClient.GetAsync(uri).Result;
            return httpResponseMessage;
        }

        public static HttpResponseMessage GetPublicProfilePicUrl(string requestParams)
        {
            HttpClient httpClient = new HttpClient();
            Uri uri = new Uri(GetApiUrl("Fbprofile") + "?userid=" + requestParams);
            httpClient.DefaultRequestHeaders.Add("X-Mashape-Key", "sSBP29CDyYmsh0q0kRjSkfArmGfQp1gL9RujsniegbbYSXn8rm");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            HttpResponseMessage httpResponseMessage = httpClient.GetAsync(uri).Result;
            return httpResponseMessage;
        }
    }
}
