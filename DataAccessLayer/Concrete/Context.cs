using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SWABRA;database=Db_CaglarPeyzaj;integrated security=true;");
        }

        public DbSet<About>? Abouts { get; set; }
        public DbSet<Advantages>? Advantages { get; set; }
        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<CustomersSay>? CustomersSays { get; set; }
        public DbSet<Feature>? Features { get; set; }
        public DbSet<FeatureTwo>? FeatureTwos { get; set; }
        public DbSet<FeatureThere>? FeatureTheres { get; set; }
        public DbSet<FeatureFour>? FeatureFours { get; set; }
        public DbSet<HomeBlog>? HomeBlogs { get; set; }
        public DbSet<Message>? Messages { get; set; }
        public DbSet<Products>? Products { get; set; }
        public DbSet<References>? References { get; set; }
        public DbSet<Services>? Services { get; set; }
        public DbSet<Setting>? Settings { get; set; }
        public DbSet<Team>? Teams { get; set; }
    }
}
