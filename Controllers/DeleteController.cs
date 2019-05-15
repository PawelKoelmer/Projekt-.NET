using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace projekt.Controllers
{
    public class DeleteController : Controller
    {
    
            //Get: /Delete/
            public IActionResult Index()
            {
                return View();
            }
        
    }
}