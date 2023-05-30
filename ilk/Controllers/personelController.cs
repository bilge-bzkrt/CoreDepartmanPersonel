using ilk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ilk.Controllers
{
    public class personelController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Personels.Include(x=>x.Departman).ToList();
            return View(degerler);
        }
    }
}
