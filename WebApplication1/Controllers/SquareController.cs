using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{

    ///<summary>
    ///Gives square of given input
    ///</summary>
    ///<param name="id"> The input we are supposed to take from the user</param>
    ///<example>
    ///     GET : /api/Square/2    ->  4
    ///     GET : /api/Square/-2   ->  4
    ///     GET : /api/Square/10   ->  100
    ///</example>
    public class SquareController : ApiController
    {
        public int get(int id)
            {
                return (id * id);
            }
    }
}
