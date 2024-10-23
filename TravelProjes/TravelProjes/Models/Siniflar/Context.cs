using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //ENTİTY PROJEYE DAHİL ETTİK NUGET PACKAGE KULLANARAK


namespace TravelProjes.Models.Siniflar
{
    public class Context:DbContext   //dbcontexten miras aldık
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog>Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<İletişim> İletişims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<Oteller> Otellers { get; set; }
        public DbSet<Müzeler> Müzelers { get; set; }




    }
}