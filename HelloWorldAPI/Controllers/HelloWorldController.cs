using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorld.Business.Implementation;
using HelloWorld.Business.Interface;

namespace HelloWorldAPI.Controllers
{
    public class HelloWorldController : ApiController
    {
        private readonly IBusinessClass _businessClass;
        
        public HelloWorldController()
        {
            _businessClass = new BusinessClass();
        }
        
        // GET api/HelloWorld
        public string Get()
        {
            var result = _businessClass.GetKeyWord();
            return result;
        }

        // GET api/HelloWorld/id
        public string Get(int id)
        {
            var result = _businessClass.GetKeyWordWithId(id);
            return result;
        }

    }
}
