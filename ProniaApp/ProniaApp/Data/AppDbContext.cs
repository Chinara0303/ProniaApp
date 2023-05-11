using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore;
using NuGet.Configuration;
using ProniaApp.Models;
using System;
using System.Diagnostics.Contracts;
using System.IO.Pipelines;
using System.Reflection.Metadata;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;

namespace ProniaApp.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
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
        public DbSet<Product> Products { get; set; }


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

            modelBuilder.Entity<SectionHeader>().HasData(
            new SectionHeader
            {
                Id = 1,
                Key = "ProductTitle",
                Value = "OUR PRODUCTS"
            },
            new SectionHeader
            {
                Id = 2,
                Key = "NewProductTitle",
                Value = "NEW PRODUCTS"
            },
            new SectionHeader
            {
                Id = 3,
                Key = "NewProductDesc",
                Value = "Contrary to popular belief, Lorem Ipsum is not simply random text.It has roots in a piece of classical Latin literature"
            },
            new SectionHeader
            {
                Id = 4,
                Key = "TestimonialTitle",
                Value = "WHAT SAY CLIENT"
            },
            new SectionHeader
            {
                Id = 5,
                Key = "TestimonialDesc",
                Value = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature"
            },
            new SectionHeader
            {
                Id = 6,
                Key = "LatestBlogTitle",
                Value = "LATEST BLOG"
            },
            new SectionHeader
            {
                Id = 7,
                Key = "LatestBlogDesc",
                Value = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature"
            },
            new SectionHeader
            {
                Id = 9,
                Key = "OurStoryTitle",
                Value = "<h2 class='about-title'>Our<span> Story</span></h2>"
            },
            new SectionHeader
            {
                Id = 10,
                Key = "OurStoryDesc",
                Value = "Lorem ipsum dolor sit amet, consectetur adipisicing elit,sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis"
            },
            new SectionHeader
            {
                Id = 11,
                Key = "CounterTitle",
                Value = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Sed ut perspiciatis"
            },
            new SectionHeader
            {
                Id = 12,
                Key = "OurTeamTitle",
                Value = "OUR TEAM"
            },
            new SectionHeader
            {
                Id = 13,
                Key = "OurTeamDesc",
                Value = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature"
            });

            modelBuilder.Entity<SectionBackgroundImage>().HasData(
            new SectionBackgroundImage
            {
                Id = 1,
                Key = "SliderBg",
                Value = "1-1.jpg"
            },
            new SectionBackgroundImage
            {
                Id = 2,
                Key = "BrandBg",
                Value = "1-1170x300.jpg"
            },
            new SectionBackgroundImage
            {
                Id = 3,
                Key = "FooterBg",
                Value = "1-1920x465.jpg"
            },
            new SectionBackgroundImage
            {
                Id = 4,
                Key = "ShopIntroBg",
                Value = "1-1-1919x388.jpg"
            },
            new SectionBackgroundImage
            {
                Id = 5,
                Key = "BlogIntroBg",
                Value = "1-1-1919x388.jpg"
            },
             new SectionBackgroundImage
             {
                 Id = 6,
                 Key = "AboutIntroBg",
                 Value = "1-1-1919x388.jpg"
             },
             new SectionBackgroundImage
             {
                 Id = 7,
                 Key = "ContactIntroBg",
                 Value = "1-1-1919x388.jpg"
             },
            new SectionBackgroundImage
            {
                Id = 8,
                Key = "ContactInfoBg",
                Value = "1-1-370x500.jpg"
            },
            new SectionBackgroundImage
            {
                Id = 9,
                Key = "CartIntroBg",
                Value = "1-1-370x500.jpg"
            },
            new SectionBackgroundImage
            {
                Id = 10,
                Key = "AccountIntroBg",
                Value = "1-1-370x500.jpg"
            },
            new SectionBackgroundImage
            {
                Id = 11,
                Key = "SingleProductIntroBg",
                Value = "1-1-1919x388.jpg"
            });
        }

    }
}
