using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class AddTenController : ApiController
    {

        ///<summary>
        ///Adds 10 to any given input
        ///</summary>
        ///<param name="id"> The input we are supposed to take from the user</param>
        ///<example>
        ///     GET : /api/AddTen/21   ->  31
        ///     GET : /api/AddTen/0    ->  10
        ///     GET : /api/AddTen/-9   ->  1
        ///</example>
        public int get(int id)
        {
            return (id + 10);
        }
    }
}
