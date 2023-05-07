using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.Configuration;
using ProniaApp.Models;
using System.Reflection.Metadata;

namespace ProniaApp.Data
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<SectionBackgroundImage> SectionBackgroundImages { get; set; }
        public DbSet<SectionHeader> SectionHeaders { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Color> Colors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<ProductImage>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<Blog>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<BlogImage>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<Category>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<ProductCategory>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<ProductSize>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<ProductTag>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<Slider>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<Brand>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<Size>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<Color>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<Tag>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<Social>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<Testimonial>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<Setting>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<SectionBackgroundImage>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<SectionHeader>().HasQueryFilter(p => !p.SoftDelete);
            modelBuilder.Entity<Advert>().HasQueryFilter(p => !p.SoftDelete);

            modelBuilder.Entity<Setting>().HasData(
            new Setting
            {
                Id = 1,
                Key = "Logo",
                Value = "dark.png"
            },
            new Setting
            {
                Id = 2,
                Key = "Phone",
                Value = "+00 123 456 789"
            },
            new Setting
            {
                Id = 3,
                Key = "Offer",
                Value = "HELLO EVERYONE!25 % Off All Products"
            },
            new Setting
            {
                Id = 4,
                Key = "PaymentImg",
                Value = "1.png"
            },
            new Setting
            {
                Id = 5,
                Key = "Email",
                Value = "info@example.com"
            },
            new Setting
            {
                Id = 6,
                Key = "Address",
                Value = "13, Your Address, Here"
            });
        }
    }
}
