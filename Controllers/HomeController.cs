using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnetapp.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public string Index()
        {
            long a = 0;
        	for(var i = 0; i < 1000000; i++) {
        	     a += i;
        	}
            return $"Value: {a}" ;
        }
       
    }
}
