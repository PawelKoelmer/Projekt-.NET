using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace projekt.Controllers
{
    public class AddController : Controller
    {
        //Get: /Add/
        public IActionResult Index(){
            return View();
        }
    }
}