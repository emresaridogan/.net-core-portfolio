using Microsoft.EntityFrameworkCore;
using Portfolio.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.DataAccess.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=EMRESARIDOGAN\\SQLEXPRESS;database=PortfolioDB;integrated security=true");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Introduction> Introductions { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolyo> Portfolyos { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
