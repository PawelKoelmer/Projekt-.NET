using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace projekt.Controllers {
    public class ShowController : Controller {
        //Get: /Show/
        public IActionResult Index () {
            ApplicationDbContext context = HttpContext.RequestServices.GetService (typeof (ApplicationDbContext)) as ApplicationDbContext;
            return View (context.getAllPersons());
        }
    }
}