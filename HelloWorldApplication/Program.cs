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
    /// <summary>
    /// The class containing the driver of the application as Main method.
    /// </summary>
    class Program
    {

       /// <summary>
       /// Main entry point for execution of the application.
       /// </summary>
       /// <param name="args"></param>
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
            //Greet with target greeter object chosen from the configuration.
            greetorTo.Greet(greetContent);

        }

        /// <summary>
        /// Provides HttpClient instance for making Rest call.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="mediaType"></param>
        /// <returns></returns>
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

        /// <summary>
        /// GreetorFactory that will provide Greeter instance based on the state of GreetingOption.
        /// </summary>
        /// <param name="greeetingOption"></param>
        /// <returns></returns>
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

    /// <summary>
    /// Enum for possible Greeting logic targets
    /// </summary>
    enum GreetingOption {
        Console,
        Database
    }

}
