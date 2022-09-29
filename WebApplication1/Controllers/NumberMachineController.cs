using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{

    ///<summary>
    ///Performs 4 mathematical operation to given input by user
    ///</summary>
    ///<param name="id"> The input we are supposed to take from the user</param>
    ///<example>
    ///     GET : /api/NumberMachine/10   ->  11
    ///     GET : /api/NumberMachine/-5   ->  -4
    ///     GET : /api/numberMachine/11   ->  12
    ///</example>
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            int avg = id - 5 + 2 * 20 / 6;
            return avg;  
        }
    }
}
