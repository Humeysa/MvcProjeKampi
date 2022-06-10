using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete
{
    public class Context: DbContext
    {
        // birer tablo kısmı olarak yer alacak
        //About : Projemizin içerisinde yer alan Classımızın ismidir.
        //Abouts : SQL de veritabanımıza yansıyacak olan tablomuzun ismidir.
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }

        //buraya yazılmış olan dbset türündeki propertyleri sql birer tablo olarak yansıtacak
    }
}
