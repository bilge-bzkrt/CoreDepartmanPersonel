using Microsoft.AspNetCore.Mvc;

namespace ilk.Controllers
{
    public class personelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
