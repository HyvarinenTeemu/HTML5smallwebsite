using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HTML5smallwebsite.Controllers
{
    public class ReplayController : Controller
    {
        public IActionResult Replays()
        {
            return View();
        }
    }
}