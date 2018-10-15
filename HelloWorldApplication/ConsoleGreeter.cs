using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    /// <summary>
    /// The class that  will implement IGreeter fir console specific target.
    /// </summary>
    class ConsoleGreeter : IGreeter
    {
        /// <summary>
        ///  The method that  will override the WriteGreet method to print the content to console.
        /// </summary>
        /// <param name="greetContent">The greetContent.</param>
        public void WriteGreet(string greetContent)
        {
            Console.WriteLine(greetContent);
            Console.ReadKey();
        }
    }
}
