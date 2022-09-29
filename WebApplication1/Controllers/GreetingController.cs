using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    ///<summary>
    ///Greets to number of people whose input is given by user
    ///</summary>
    ///<param name="id"> The input we are supposed to take from the user</param>
    ///<example>
    ///     GET : /api/Greeting/3   ->  Greetings to 3 people!
    ///     GET : /api/Greeting/6   ->  Greetings to 6 people!
    ///     GET : /api/Greeting/0   ->  Greetings to 0 people!
    ///     
    ///     POST : "Hello World"
    ///</example>
    public class GreetingController : ApiController
    {
        public string Get(string id)
        {
            return "Greetings to " + id + " people!";
        }

        public string Post()
        {
            return "Hello World!";
        }
    }
}
