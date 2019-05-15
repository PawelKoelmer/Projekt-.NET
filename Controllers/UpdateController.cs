using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace projekt.Controllers
{
    public class UpdateController: Controller
    {
        //Get: /Update/
        public IActionResult Index()
        {
            return View();
        }
    }
}