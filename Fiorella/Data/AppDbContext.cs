using System;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Models
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) :base(options){ }

		public DbSet<Slider> Sliders{ get; set; }

        public DbSet<SliderInfo> SliderInfos { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Expert> Experts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<Social> Socials { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Expert>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Category>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Product>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Social>().HasQueryFilter(m => !m.SoftDeleted);


            modelBuilder.Entity<Setting>().HasData(
          new Setting
          {
              Id = 1,
              Key="HeaderLogo",
              Value="logo.png",
              SoftDeleted=false,
              CreatedDate = DateTime.Now
          },
           new Setting
           {
               Id = 2,
               Key = "Phone",
               Value = "243571623",
               SoftDeleted = false,
               CreatedDate = DateTime.Now
           }, new Setting
           {
               Id = 3,
               Key = "Address",
               Value = "Ehmedli",
               SoftDeleted = false,
               CreatedDate = DateTime.Now
           }

          );




            modelBuilder.Entity<Blog>().HasData(
            new Blog
            {
                Id = 1,
                Title = "Title1",
                Description = "Reshadin Blogu",
                Image= "blog-feature-img-1.jpg",
                CreatedDate=DateTime.Now
            },
             new Blog
             {
                 Id = 2,
                 Title = "Title2",
                 Description = "Ilqarin Blogu",
                 Image = "blog-feature-img-3.jpg",
                 CreatedDate = DateTime.Now
             }, new Blog
             {
                 Id = 3,
                 Title = "Title3",
                 Description = "Hacixanin Blogu",
                 Image = "blog-feature-img-4.jpg",
                 CreatedDate = DateTime.Now
             }

            );

            modelBuilder.Entity<Social>().HasData(
           new Social
           {
               Id = 1,
               Name = "Youtube",
               Icon = "zmdi zmdi-youtube",
               URL = "https://www.youtube.com",
               CreatedDate = DateTime.Now
           },
           new Social
           {
               Id = 2,
               Name = "Pinterest",
               Icon = "zmdi zmdi-pinterest",
               URL = "https://www.pinterest.com",
               CreatedDate = DateTime.Now
           },
           new Social
           {
               Id = 3,
               Name = "LinkedIn",
               Icon = "zmdi zmdi-linkedin",
               URL = "https://www.linkedin.com",
               CreatedDate = DateTime.Now
           },
           new Social
           {
               Id = 4,
               Name = "Amazon",
               Icon = "zmdi zmdi-amazon",
               URL = "https://www.amazon.com",
               CreatedDate = DateTime.Now
           }

           );

            modelBuilder.Entity<Expert>().HasData(
            new Expert
            {
                Id = 1,
                FullName = "Fatima Gaykhanova",
                Position = "Florist",
                Image = "h3-team-img-1.png",
                CreatedDate = DateTime.Now
            },
            new Expert
            {
                  Id = 2,
                  FullName = "Inji Gaykhanova",
                  Position = "Manager",
                  Image = "h3-team-img-2.png",
                  CreatedDate = DateTime.Now
            },
            new Expert
            {
                  Id = 3,
                  FullName = "Fidan Gaykhanova",
                  Position = "Florist",
                  Image = "h3-team-img-3.png",
                  CreatedDate = DateTime.Now
            },
            new Expert
            {
                    Id = 4,
                    FullName = "Gunel Hasanova",
                    Position = "Florist",
                    Image = "h3-team-img-4.png",
                    CreatedDate = DateTime.Now
            });



            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1111,
                Name = "POPULAR",
                SoftDeleted = false,
                CreatedDate = DateTime.Now
            },
             new Category
             {
                 Id = 1112,
                 Name = "WINTER",
                 SoftDeleted = false,
                 CreatedDate = DateTime.Now
             },
             new Category
             {
                 Id = 1113,
                 Name = "VARIOUS",
                 SoftDeleted = false,
                 CreatedDate = DateTime.Now
             },
             new Category
             {
                 Id = 1114,
                 Name = "EXOTIC",
                 SoftDeleted = false,
                 CreatedDate = DateTime.Now
             },
             new Category
             {
                 Id = 1115,
                 Name = "GREENS",
                 SoftDeleted = false,
                 CreatedDate = DateTime.Now
             },
             new Category
             {
                 Id = 1116,
                 Name = "CACTUSES",
                 SoftDeleted = false,
                 CreatedDate = DateTime.Now
             },
             new Category
             {
                 Id = 1117,
                 Name = "ROSES",
                 SoftDeleted = false,
                 CreatedDate = DateTime.Now
             });





            modelBuilder.Entity<Product>().HasData(
            
            new Product
            {
                Id = 1006,
                Name = "Product6",
                Price = 20,
                Description = "Desc6",
                CategoryId = 1113,
                SoftDeleted = false,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 1007,
                Name = "Product7",
                Price = 7000,
                Description = "Desc7",
                CategoryId = 1114,
                SoftDeleted = false,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 1008,
                Name = "Product8",
                Price = 2300,
                Description = "Desc8",
                CategoryId = 1114,
                SoftDeleted = false,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 1009,
                Name = "Product9",
                Price = 240,
                Description = "Desc9",
                CategoryId = 1115,
                SoftDeleted = false,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 1010,
                Name = "Product10",
                Price = 750,
                Description = "Desc10",
                CategoryId = 1115,
                SoftDeleted = false,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 1111,
                Name = "Product11",
                Price = 300,
                Description = "Desc11",
                CategoryId = 1116,
                SoftDeleted = false,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 1112,
                Name = "Product12",
                Price = 450,
                Description = "Desc12",
                CategoryId = 1116,
                SoftDeleted = false,
                CreatedDate = DateTime.Now
            });





            modelBuilder.Entity<ProductImage>().HasData(
            new ProductImage
            {
                Id = 1000,
                Name = "shop-14-img.jpg",
                IsMain = true,
                ProductId = 1006
            },
            new ProductImage
            {
                Id = 1002,
                Name = "shop-7-img.jpg",
                IsMain = false,
                ProductId = 1006
            },
            new ProductImage
            {
                Id = 1003,
                Name = "shop-10-img.jpg",
                IsMain = true,
                ProductId = 1007
            },
            new ProductImage
            {
                Id = 1004,
                Name = "shop-10-img.jpg",
                IsMain = false,
                ProductId = 1007
            },
            new ProductImage
            {
                Id = 1005,
                Name = "shop-9-img.jpg",
                IsMain = true,
                ProductId = 1008
            },
            new ProductImage
            {
                Id = 1006,
                Name = "shop-9-img.jpg",
                IsMain = false,
                ProductId = 1008
            });

            






        }
    }
}

