using ilk.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ilk.Controllers
{
	public class LoginController : Controller
	{
		Context c = new Context();
		[HttpGet]
		public IActionResult GirisYap()
		{
			return View();
		}

		public async Task<IActionResult> GirisYap(Admin p)  //async eklendi. identity kullanılacağı için asyns eklendi. önünde de Task<> komutu yazıldı.
		{
			var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == p.Kullanici && x.Sifre == p.Sifre);
			if (bilgiler != null)
			{
				var claims = new List<Claim> 
				{
					new Claim(ClaimTypes.Name, p.Kullanici) 
				};

				var userIdentity = new ClaimsIdentity(claims, "Login");
				ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index", "personel");
			}
			return View();
		}
	}
}
