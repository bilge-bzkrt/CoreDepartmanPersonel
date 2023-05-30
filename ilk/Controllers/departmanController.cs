using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ilk.Models;
using System.Runtime.CompilerServices;

namespace ilk.Controllers
{
    public class departmanController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var degerler = c.Departmans;
            return View(degerler);
        }

        [HttpGet]
        public IActionResult DepartmanEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DepartmanEkle(Departman d)
        {
            c.Departmans.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult DepartmanSil(int id)
        {
            var deger = c.Departmans.Find(id);
            c.Departmans.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanGetir(int id)
        {
            var deger = c.Departmans.Find(id);
            return View("DepartmanGetir", deger);
        }

        public IActionResult DepartmanGuncelle(Departman d)
        {
            var dprtmn = c.Departmans.Find(d.departman_id);
            dprtmn.departman_adi = d.departman_adi;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanDetay(int id)
        {
            var degerler = c.Personels.Where(x=>x.Departman.departman_id==id).ToList();
            var departAd = c.Departmans.Where(x => x.departman_id==id).Select(y=>y.departman_adi).FirstOrDefault();
            ViewBag.DepartmanAd = departAd;
            return View(degerler);
        }
    }
}
