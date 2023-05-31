using ilk.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ilk.Controllers
{
    public class personelController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Personels.Include(x=>x.Departman).ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in c.Departmans.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.departman_adi, Value = x.departman_id.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();  
        }

        [HttpPost]
        public IActionResult YeniPersonel(Personel p)
        {
            var per = c.Departmans.Where(x=>x.departman_id==p.Departman.departman_id).FirstOrDefault();
            p.Departman = per;
            c.Personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
