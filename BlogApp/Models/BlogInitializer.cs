using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="Futbol"},
                new Category(){KategoriAdi="Basketbol"},
                new Category(){KategoriAdi="Voleybol"},
                new Category(){KategoriAdi="Atletizm"}
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }

            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){Baslik="Premier Lig",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde.",EklenmeTarihi=DateTime.Now.AddDays(-10),AnaSayfa=true,Onay=true,Icerik="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir.",Resim="1.jpg",CategoryId=1},
                new Blog(){Baslik="NBA",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde.",EklenmeTarihi=DateTime.Now.AddDays(-20),AnaSayfa=true,Onay=true,Icerik="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir.",Resim="2.jpg",CategoryId=2},
                new Blog(){Baslik="Dunya Sampiyonasi",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde.",EklenmeTarihi=DateTime.Now.AddDays(-30),AnaSayfa=true,Onay=true,Icerik="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir.",Resim="3.jpg",CategoryId=3},
                new Blog(){Baslik="Olimpiyatlar",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde.",EklenmeTarihi=DateTime.Now.AddDays(-40),AnaSayfa=false,Onay=true,Icerik="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir.",Resim="4.jpg",CategoryId=4}
            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}