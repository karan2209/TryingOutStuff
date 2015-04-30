using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TryingOutStuff
{
    class RestGetCountryInfo
    {
        static void Main(string[] args)
        {
            HttpResponseMessage httpResponseMessage = GetCountryInfoByCode("IN");
            Console.WriteLine(httpResponseMessage.ToString());
        }

        public static HttpResponseMessage GetCountryInfoByCode(string code)
        {
            HttpClient httpClient = new HttpClient();
            Uri uri = new Uri("https://restcountries.p.mashape.com/alpha/" + code);
            httpClient.DefaultRequestHeaders.Add("X-Mashape-Key", "sSBP29CDyYmsh0q0kRjSkfArmGfQp1gL9RujsniegbbYSXn8rm");
            HttpResponseMessage httpResponseMessage = httpClient.GetAsync(uri).Result;
            return httpResponseMessage;
        }
    }
}
