using Microsoft.AspNetCore.Mvc;

namespace NodeManager.Web.Controllers
{
    public class NavController : Controller
    {
        // GET
        public IActionResult Menu()
        {
            return View();
        }
    }
}