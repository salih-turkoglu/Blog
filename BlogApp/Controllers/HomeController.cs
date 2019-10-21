using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        public ActionResult Index()
        {
            var bloglar = context.Bloglar
                                .Where(i => i.Onay == true && i.AnaSayfa == true)
                                .Select(i => new BlogModel()
                                {
                                    Id = i.Id,
                                    Baslik = i.Baslik.Length > 100 ? i.Baslik.Substring(0, 100) + "..." : i.Baslik,
                                    Aciklama = i.Aciklama,
                                    EklenmeTarihi = i.EklenmeTarihi,
                                    AnaSayfa = i.AnaSayfa,
                                    Onay = i.Onay,
                                    Resim = i.Resim
                                });


            return View(bloglar.ToList());
        }
    }
}