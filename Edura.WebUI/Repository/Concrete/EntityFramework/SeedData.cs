using Edura.WebUI.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<EduraContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                var products = new[]
                {
                    new Product(){ProductName="Photo Camera",Price=545,Image="product1.jpg",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.",HtmlContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. <b>Proin varius arcu metus.</b>",DateAdded=DateTime.Now.AddDays(-10)},
                    new Product(){ProductName="Comfortable Sofa",Price=545,Image="product3.jpg",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.",HtmlContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi.<b> Proin varius arcu metus.</b>",DateAdded=DateTime.Now.AddDays(-15)},
                    new Product(){ProductName="Hand Bag",Price=5323232325,Image="product4.jpg",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.",HtmlContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi.<b> Proin varius arcu metus.</b>",DateAdded=DateTime.Now.AddDays(-8)},
                    new Product(){ProductName="Sofa",Price=5445,Image="product3.jpg",Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. Proin varius arcu metus.",HtmlContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vitae vehicula enim. Sed quis ante quis eros maximus dignissim a eu mi. <b>Proin varius arcu metus.</b>",DateAdded=DateTime.Now.AddDays(-5)}
                };
                context.Products.AddRange(products);
                var categories = new[]
                {
                    new Category(){CategoryName="Electronics"},
                    new Category(){CategoryName="Accesories"},
                    new Category(){CategoryName="Furnituere"}
                };
                context.Categories.AddRange(categories);
                var productCategory = new[]
                {
                    new ProductCategory(){Product=products[0],Category=categories[0]},
                    new ProductCategory(){Product=products[1],Category=categories[0]},
                    new ProductCategory(){Product=products[2],Category=categories[1]},
                    new ProductCategory(){Product=products[3],Category=categories[2]}
                };
                var images = new[]
                {
                    new Image(){ImageName="product1.jpg",Product=products[0]},
                    new Image(){ImageName="product1.jpg",Product=products[0]},
                    new Image(){ImageName="product1.jpg",Product=products[0]},
                    new Image(){ImageName="product1.jpg",Product=products[0]},

                    new Image(){ImageName="product2.jpg",Product=products[1]},
                    new Image(){ImageName="product2.jpg",Product=products[1]},
                    new Image(){ImageName="product2.jpg",Product=products[1]},
                    new Image(){ImageName="product2.jpg",Product=products[1]},

                    new Image(){ImageName="product3.jpg",Product=products[2]},
                    new Image(){ImageName="product3.jpg",Product=products[2]},
                    new Image(){ImageName="product3.jpg",Product=products[2]},
                    new Image(){ImageName="product3.jpg",Product=products[2]},

                    new Image(){ImageName="product4.jpg",Product=products[3]},
                    new Image(){ImageName="product4.jpg",Product=products[3]},
                    new Image(){ImageName="product4.jpg",Product=products[3]},
                    new Image(){ImageName="product4.jpg",Product=products[3]}
                };
                context.Images.AddRange(images);
                var attributes = new[]
                {
                    new ProductAttribute(){Attribute="Display",Value="15.6",Product=products[0]},
                    new ProductAttribute(){Attribute="Processor",Value="Intel i7",Product=products[0]},
                    new ProductAttribute(){Attribute="Ram Memory",Value="58 Gb",Product=products[0]},
                    new ProductAttribute(){Attribute="Hard Disk",Value="1 Tb",Product=products[0]},
                    new ProductAttribute(){Attribute="Color",Value="Black",Product=products[0]},

                    new ProductAttribute(){Attribute="Display",Value="15.6",Product=products[1]},
                    new ProductAttribute(){Attribute="Processor",Value="Intel i7",Product=products[1]},
                    new ProductAttribute(){Attribute="Ram Memory",Value="58 Gb",Product=products[1]},
                    new ProductAttribute(){Attribute="Hard Disk",Value="1 Tb",Product=products[1]},
                    new ProductAttribute(){Attribute="Color",Value="Black",Product=products[1]},

                    new ProductAttribute(){Attribute="Display",Value="15.6",Product=products[2]},
                    new ProductAttribute(){Attribute="Processor",Value="Intel i7",Product=products[2]},
                    new ProductAttribute(){Attribute="Ram Memory",Value="58 Gb",Product=products[2]},
                    new ProductAttribute(){Attribute="Hard Disk",Value="1 Tb",Product=products[2]},
                    new ProductAttribute(){Attribute="Color",Value="Black",Product=products[2]},

                    new ProductAttribute(){Attribute="Display",Value="15.6",Product=products[3]},
                    new ProductAttribute(){Attribute="Processor",Value="Intel i7",Product=products[3]},
                    new ProductAttribute(){Attribute="Ram Memory",Value="58 Gb",Product=products[3]},
                    new ProductAttribute(){Attribute="Hard Disk",Value="1 Tb",Product=products[3]},
                    new ProductAttribute(){Attribute="Color",Value="Black",Product=products[3]},


                };
                context.ProductAttributes.AddRange(attributes);
                context.AddRange(productCategory);
                context.SaveChanges();
            }
        }
    }
}
