using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    /// <summary>
    /// GreetTo class containing Greet logic.
    /// </summary>
    public class GreetTo
    {
        private IGreeter Greeter;
        public GreetTo(IGreeter Greeter)
        {
            this.Greeter = Greeter;
        }

        /// <summary>
        /// Wrapper of the Greet logic from the IGreeter concrete implementation.
        /// </summary>
        /// <param name="greetContent"></param>
        public void Greet(string greetContent)
        {
            Greeter.WriteGreet(greetContent);
        }
    }
}
