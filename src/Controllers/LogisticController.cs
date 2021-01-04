using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shiptoboxes.WebMvc.Controllers
{
    public class LogisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
