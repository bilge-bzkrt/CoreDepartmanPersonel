using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ilk.Models;

namespace ilk.Controllers
{
    public class departmanController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var degerler = c.departmans;
            return View(degerler);
        }

        [HttpGet]
        public IActionResult DepartmanEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DepartmanEkle(departmanlar d)
        {
            c.departmans.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
