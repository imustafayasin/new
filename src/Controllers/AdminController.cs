using Microsoft.AspNetCore.Mvc;

namespace Shiptoboxes.WebMvc.Controllers
{
    public class AdminController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }


    }
}
