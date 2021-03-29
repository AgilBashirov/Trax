using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trax.Models;

namespace Trax.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BusinessHour> BusinessHours { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<GalleryType> GalleryTypes { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<GalleryToType> GalleryToTypes { get; set; }
        public DbSet<Mobile> Mobiles { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<PeopleSay> PeopleSays { get; set; }
        public DbSet<Process> Process { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<PricingTable> PricingTables { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SkillSet> SkillSets { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<SocialToUser> SocialToUser { get; set; }
        public DbSet<Subscribe> Subscribe { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagToBlog> TagToBlog { get; set; }
        public DbSet<Universal> Universal { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Counter> Counter { get; set; }
    }
}
