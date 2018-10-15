using HelloWorldRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloworldApi.Controllers
{
    public class HelloWorldController : ApiController
    {
        // private IHelloWorldManager 
        private readonly IHelloWorldRepository _helloWorldRepository;

        public HelloWorldController(IHelloWorldRepository helloWorldRepository)
        {
            _helloWorldRepository = helloWorldRepository;
        }

      
        [HttpGet]
        [Route("Greet")]
        public string Greet()
        {
            return _helloWorldRepository.Greet();
        }

       
    }
}