using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    class GreetTo
    {
        private IGreeter Greeter;
        public GreetTo(IGreeter Greeter)
        {
            this.Greeter = Greeter;
        }

        public void Greet(string greetContent)
        {
            Greeter.WriteGreet(greetContent);
        }
    }
}
