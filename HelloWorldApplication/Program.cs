using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    class Program
    {
       
        static  void Main(string[] args)
        {
            GreetingOption greetingOption;
            Enum.TryParse<GreetingOption>(ConfigurationManager.AppSettings["GreetingOtion"], true, out greetingOption);

            var greetorTo = new GreetTo(GreeterFactory(greetingOption));
            string greetContent = string.Empty;

            var baseAddress = ConfigurationManager.AppSettings["BaseAddress"];
            var mediaType = ConfigurationManager.AppSettings["MediaType"];
            HttpResponseMessage response = GetClient(baseAddress, mediaType).GetAsync("/Greet").Result;
            if (response.IsSuccessStatusCode)
            {
                greetContent =  response.Content.ReadAsStringAsync().Result;
            }
          
            greetorTo.Greet(greetContent);

        }
        static HttpClient GetClient(string url, string mediaType)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(url)
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));
            return client;
        }

        static IGreeter GreeterFactory(GreetingOption greeetingOption)
        {
            if (greeetingOption == GreetingOption.Console)
            {
                return new ConsoleGreeter();

            }
            else if (greeetingOption == GreetingOption.Database)
            {
                return new DataBaseGreeter();
            }
            return null;
        }
    }
    enum GreetingOption {
        Console,
        Database
    }

}
