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

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("Greet")]
        public string Greet()
        {
            return _helloWorldRepository.Greet();
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}