using eShopSolution.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is key word of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() {Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false } );

            modelBuilder.Entity<Category>().HasData(
                new Category() 
                {   
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null, 
                    SortOrder = 1,
                    Status = Enums.Status.Active
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Enums.Status.Active
                    
                    
                }
                );
            modelBuilder.Entity<CategoriesTranslation>().HasData(
                new CategoriesTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Áo nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm thời trang nam",
                    SeoTitle = "Sản phẩm thời trang nam"
                },
                new CategoriesTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Men Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "men-shirt",
                    SeoDescription = "The shirt products for men",
                    SeoTitle = "The shirt products for men"
                },
                new CategoriesTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Áo nữ",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nu",
                    SeoDescription = "Sản phẩm thời trang nữ",
                    SeoTitle = "Sản phẩm thời trang nữ"
                },
                new CategoriesTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Women Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "Women-shirt",
                    SeoDescription = "The shirt products for women",
                    SeoTitle = "The shirt products for women"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 150000,
                    Stock = 0,
                    ViewCount = 0,
                    
                },
                new Product()
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 130000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,
                    
                });
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo sơ mi nam trắng Việt Tiến",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                    SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                    SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                    Details = "Áo sơ mi nam trắng Việt Tiến",
                    Description = "Áo sơ mi nam trắng Việt Tiến"
                },
                new ProductTranslation()
                {
                    Id=2,
                    ProductId = 1,
                    Name = "Viet Tien Men T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "Viet Tien Men T-Shirt",
                    SeoDescription = "Viet Tien Men T-Shirt",
                    SeoTitle = "Viet Tien Men T-Shirt",
                    Details = "Viet Tien Men T-Shirt",
                    Description = "Viet Tien Men T-Shirt"
                },
                new ProductTranslation()
                {
                    Id = 3,
                    ProductId = 2,
                    Name = "Áo sơ mi nữ trắng Việt Tiến",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-so-mi-nu-trang-viet-tien",
                    SeoDescription = "Áo sơ mi nữ trắng Việt Tiến",
                    SeoTitle = "Áo sơ mi nữ trắng Việt Tiến",
                    Details = "Áo sơ mi nữ trắng Việt Tiến",
                    Description = "Áo sơ mi nữ trắng Việt Tiến"
                },
                new ProductTranslation()
                {
                    Id = 4, 
                    ProductId = 2,
                    Name = "Viet Tien Women T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "Viet Tien Women T-Shirt",
                    SeoDescription = "Viet Tien Women T-Shirt",
                    SeoTitle = "Viet Tien Women T-Shirt",
                    Details = "Viet Tien Women T-Shirt",
                    Description = "Viet Tien Women T-Shirt"
                });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() 
                { 
                    ProductId = 1,
                    CategoryId = 1
                },
                new ProductInCategory() 
                {
                    ProductId = 2,
                    CategoryId = 2
                });
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Id = new Guid( "247445AC-36FA-4CAF-BC47-536BC5FD48E1"),
                    Name = "admin",
                    NormalizedName = "admin",
                    Description = "Adminitrator role"
                });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = new Guid ("0CB1A7B9-290D-4E1C-8525-55CA1825ECA4"),
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "giappham345@gmail.com",
                    NormalizedEmail = "giappham345@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "12345"),
                    SecurityStamp = string.Empty,
                    FirstName = "Quang",
                    LastName = "Giáp",
                    Dob = new DateTime(2002,09,29)
                });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("247445AC-36FA-4CAF-BC47-536BC5FD48E1"),
                    UserId = new Guid("0CB1A7B9-290D-4E1C-8525-55CA1825ECA4")
                });

        }
    }
}
