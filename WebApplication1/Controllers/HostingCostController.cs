using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HostingCostController : ApiController
    {
        ///<summary>
        ///Gives Hosting Price as per fortnight in CAD given input by user
        ///</summary>
        ///<param name="id"> The input we are supposed to take from the user</param>
        ///<example>
        ///     GET : /api/HostingCost/0   
        ///         1 is your fortnight and the price is $5.50 CAD
        ///         HST 13% = $0.715CAD
        ///         Total is: $6.215CAD
        ///         
        ///     GET : /api/HostingCost/14
        ///         2 is your fortnight and the price is $5.50 CAD
        ///         HST 13% = $1.43CAD
        ///         Total is: $12.43CAD
        ///         
        ///     GET : /api/HostingCost/28
        ///         3 is your fortnight and the price is $5.50 CAD
        ///         HST 13% = $2.145CAD
        ///         Total is: $18.645CAD
        ///</example>
        public IEnumerable<string> Get(int id)
        {
            int fn = id / 14;
            int fnplus = fn + 1;
            double fnprice = 5.50;
            double ftotal = fnplus * fnprice;
            double tax = (ftotal * 0.13);
            double finalTotal = ftotal + tax;

            return new string[] {fnplus.ToString() + " is your fortnight and the price is $5.50 CAD", "HST 13% = $" + tax.ToString() + "CAD", "Total is: $" + finalTotal.ToString() + "CAD"};
        }
    }
}
