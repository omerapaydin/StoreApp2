using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StoreApp2.Entity;

namespace StoreApp2.Models
{
    public static class ModelBuilderExtensions
    {
         public static void Seed(this ModelBuilder modelBuilder)
        {


            
            var hasher = new PasswordHasher<ApplicationUser>();

            var user = new ApplicationUser
            {
                Id = "1",
                UserName = "omerapaydin",
                Email = "info@gmail.com",
                ImageFile = "p1.jpg",
                FullName = "Ömer Apaydın",
                EmailConfirmed = true 
            };

            user.PasswordHash = hasher.HashPassword(user, "User123!");

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

            modelBuilder.Entity<ApplicationUser>().HasData(user, user2);
            
             modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Telefonlar"  },
                new Category { CategoryId = 2, Name = "Bilgisayarlar" },
                new Category { CategoryId = 3, Name = "Aksesuarlar" }
            );

           
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Title = "Apple", Description = "Apple Iphone 12 64GB Sarı Cep Telefonu", PublishedOn = DateTime.Now.AddDays(-50), Image = "homepod.jpg",Price = 45000, IsActive= true,UserId = "1" ,CategoryId = 1},
                new Product { ProductId = 2, Title = "Apple", Description = " Apple Iphone 14 128GB Sarı Cep Telefonu", PublishedOn = DateTime.Now.AddDays(-20), Image = "battery_charger__f8vsiut6h1aq_large_2x.jpg",Price = 55000, IsActive= true, UserId = "1" ,CategoryId = 1},
                new Product { ProductId = 3, Title = "Apple", Description = " Apple Iphone 15 64GB Sarı Cep Telefonu", PublishedOn = DateTime.Now.AddDays(-60), Image = "airpods-pro-2-hero-select-202409.png", Price = 75000, IsActive= true,UserId = "2" ,CategoryId = 1}
            );
        }

    }
}