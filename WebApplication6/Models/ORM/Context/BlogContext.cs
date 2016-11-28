using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebApplication6.Models.ORM.Entity;

namespace WebApplication6.Models.ORM.Context
{
    public class BlogContext:DbContext
    {
        public BlogContext()
        {
            Database.Connection.ConnectionString = "server=.;database=blogtekrar;trusted_connection=true;";
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
        }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SiteMenu> SiteMenus { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}