using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    class ConsoleGreeter : IGreeter
    {
       
        public void WriteGreet(string greetContent)
        {
            Console.WriteLine(greetContent);
            Console.ReadKey();
        }
    }
}
