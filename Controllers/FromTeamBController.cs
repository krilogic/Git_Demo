using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Git_Demo.Controllers
{
    public class FromTeamBController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
