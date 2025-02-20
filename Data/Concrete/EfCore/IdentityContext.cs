using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using StoreApp2.Entity;

namespace StoreApp2.Data.Concrete.EfCore
{
    public class IdentityContext:IdentityDbContext<ApplicationUser>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options):base(options)
        {
            
       
        }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories  => Set<Category>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }



         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var hasher = new PasswordHasher<ApplicationUser>();

            // Kullanıcılar
            var user1 = new ApplicationUser
            {
                Id = "1",
                UserName = "omerapaydin",
                Email = "info@gmail.com",
                ImageFile = "p1.jpg",
                FullName = "Ömer Apaydın",
                EmailConfirmed = true
            };
            user1.PasswordHash = hasher.HashPassword(user1, "User123!");

            var user2 = new ApplicationUser
            {
                Id = "2",
                UserName = "ahmettambuga",
                Email = "info2@gmail.com",
                ImageFile = "p2.jpg",
                FullName = "Ahmet Tamboğa",
                EmailConfirmed = true
            };
            user2.PasswordHash = hasher.HashPassword(user2, "User2Password!");

            modelBuilder.Entity<ApplicationUser>().HasData(user1, user2);

            // Kategoriler
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Telefonlar" },
                new Category { CategoryId = 2, Name = "Bilgisayarlar" },
                new Category { CategoryId = 3, Name = "Aksesuarlar" }
            );

            // Ürünler
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Title = "Apple",
                Description = "Apple HomePod Hoparlör",
                PublishedOn = new DateTime(2024, 1, 1),  
                Image = "homepod.jpg",
                Price = 45000,
                IsActive = true,
                UserId = "1",
                CategoryId = 1
            },
            new Product
            {
                ProductId = 2,
                Title = "Apple",
                Description = "Apple Şarj Kablosu Magsafe",
                PublishedOn = new DateTime(2024, 2, 1),  
                Image = "magsafe.jpg",
                Price = 55000,
                IsActive = true,
                UserId = "1",
                CategoryId = 1
            },
            new Product
            {
                ProductId = 3,
                Title = "Apple",
                Description = "Apple AirPods Pro 2",
                PublishedOn = new DateTime(2024, 3, 1),  
                Image = "airpods-pro-2-hero-select-202409.png",
                Price = 75000,
                IsActive = true,
                UserId = "2",
                CategoryId = 1
            },
            new Product
            {
                ProductId = 4,
                Title = "Apple",
                Description = "Apple AirPods Pro 2",
                PublishedOn = new DateTime(2024, 3, 1),  
                Image = "airpods-max.jpeg",
                Price = 75000,
                IsActive = true,
                UserId = "2",
                CategoryId = 2
            },
            new Product
            {
                ProductId = 5,
                Title = "Apple",
                Description = "Apple Key Pro 2",
                PublishedOn = new DateTime(2024, 3, 1),  
                Image = "key.jpeg",
                Price = 75000,
                IsActive = true,
                UserId = "2",
                CategoryId = 2
            },
            new Product
            {
                ProductId = 6,
                Title = "Apple",
                Description = "Apple Mouse Pro ",
                PublishedOn = new DateTime(2024, 3, 1),  
                Image = "mouse.jpeg",
                Price = 75000,
                IsActive = true,
                UserId = "2",
                CategoryId = 3
            }
        );
        }

    }

   
}