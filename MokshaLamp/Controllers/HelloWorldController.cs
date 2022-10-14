using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace MokshaLamp.Controllers
{
    public class HelloWorldController : Controller // class
    {
        public string Index() //Index Method
        {
            return "This is my default action...";
        }

        // GET: /HelloWorld/Welcome/ 

        public string Welcome() 
        {
            return "This is the Welcome action method..."; // Welcome message
        }
    }
}
