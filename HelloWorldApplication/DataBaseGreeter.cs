using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    /// <summary>
    ///  The class that  will implement IGreet interface for the database specific target.
    /// </summary>
    class DataBaseGreeter : IGreeter
    {
        /// <summary>
        ///  The method that  will override the WriteGreet method to save the content to database. 
        /// </summary>
        /// <param name="greetContent"></param>
        public void WriteGreet(string greetContent)
        {
            //ToDo: To be implemented in the future.
            throw new NotImplementedException();
        }
    }
}
