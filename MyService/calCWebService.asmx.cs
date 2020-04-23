using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyService
{
    /// <summary>
    /// Summary description for calCWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class calCWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public int add(int a, int b)
        {
            return a + b;
        }
        [WebMethod]
        public int sub(int a, int b)
        {
            return a - b;
        }
        [WebMethod]
        public int mul(int a, int b)
        {
            return a * b;
        }
        [WebMethod]
        public int div(int a, int b)
        {
            return a / b;
        }

    }
}
