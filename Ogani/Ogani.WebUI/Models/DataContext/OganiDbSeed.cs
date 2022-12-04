using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ogani.WebUI.Models.Entity;

namespace Ogani.WebUI.Models.DataContext
{
	public static class OganiDbSeed
	{
		internal static IApplicationBuilder Seed(this IApplicationBuilder app)
		{
			using(var scope = app.ApplicationServices.CreateScope())
			{
				var db = scope.ServiceProvider.GetRequiredService<OganiDbContext>();

				db.Database.Migrate();

				InitCategories(db);
				InitProductUnits(db);
				InitProducts(db);
            }

			return app;
		}

        private static void InitProducts(OganiDbContext db)
        {
            if (!db.Products.Any())
            {
                var category = db.Categories.FirstOrDefault();
                var unit = db.ProductUnits.FirstOrDefault();

                if (category != null && unit != null)
                {
                    Product product = new Product
                    {
                        Name = "Vetgetable’s Package",
                        ShortDescription = "Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Vestibulum ac diam sit amet quam vehicula elementum sed sit amet dui. Sed porttitor lectus nibh. Vestibulum ac diam sit amet quam vehicula elementum sed sit amet dui. Proin eget tortor risus.",
                        Price = 50.99M,
                        Weight = 0.5M,
                        Description = @"<h6>Products Infomation</h6>
                                    <p>
                                        Vestibulum ac diam sit amet quam vehicula elementum sed sit amet dui.
                                        Pellentesque in ipsum id orci porta dapibus. Proin eget tortor risus. Vivamus
                                        suscipit tortor eget felis porttitor volutpat. Vestibulum ac diam sit amet quam
                                        vehicula elementum sed sit amet dui. Donec rutrum congue leo eget malesuada.
                                        Vivamus suscipit tortor eget felis porttitor volutpat. Curabitur arcu erat,
                                        accumsan id imperdiet et, porttitor at sem. Praesent sapien massa, convallis a
                                        pellentesque nec, egestas non nisi. Vestibulum ac diam sit amet quam vehicula
                                        elementum sed sit amet dui. Vestibulum ante ipsum primis in faucibus orci luctus
                                        et ultrices posuere cubilia Curae; Donec velit neque, auctor sit amet aliquam
                                        vel, ullamcorper sit amet ligula. Proin eget tortor risus.
                                    </p>
                                    <p>
                                        Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Lorem
                                        ipsum dolor sit amet, consectetur adipiscing elit. Mauris blandit aliquet
                                        elit, eget tincidunt nibh pulvinar a. Cras ultricies ligula sed magna dictum
                                        porta. Cras ultricies ligula sed magna dictum porta. Sed porttitor lectus
                                        nibh. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a.
                                        Vestibulum ac diam sit amet quam vehicula elementum sed sit amet dui. Sed
                                        porttitor lectus nibh. Vestibulum ac diam sit amet quam vehicula elementum
                                        sed sit amet dui. Proin eget tortor risus.
                                    </p>",
                        Information = @"<h6>Products Infomation</h6>
                                    <p>
                                        Vestibulum ac diam sit amet quam vehicula elementum sed sit amet dui.
                                        Pellentesque in ipsum id orci porta dapibus. Proin eget tortor risus. Vivamus
                                        suscipit tortor eget felis porttitor volutpat. Vestibulum ac diam sit amet quam
                                        vehicula elementum sed sit amet dui. Donec rutrum congue leo eget malesuada.
                                        Vivamus suscipit tortor eget felis porttitor volutpat. Curabitur arcu erat,
                                        accumsan id imperdiet et, porttitor at sem. Praesent sapien massa, convallis a
                                        pellentesque nec, egestas non nisi. Vestibulum ac diam sit amet quam vehicula
                                        elementum sed sit amet dui. Vestibulum ante ipsum primis in faucibus orci luctus
                                        et ultrices posuere cubilia Curae; Donec velit neque, auctor sit amet aliquam
                                        vel, ullamcorper sit amet ligula. Proin eget tortor risus.
                                    </p>
                                    <p>
                                        Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Lorem
                                        ipsum dolor sit amet, consectetur adipiscing elit. Mauris blandit aliquet
                                        elit, eget tincidunt nibh pulvinar a. Cras ultricies ligula sed magna dictum
                                        porta. Cras ultricies ligula sed magna dictum porta. Sed porttitor lectus
                                        nibh. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a.
                                        Vestibulum ac diam sit amet quam vehicula elementum sed sit amet dui. Sed
                                        porttitor lectus nibh. Vestibulum ac diam sit amet quam vehicula elementum
                                        sed sit amet dui. Proin eget tortor risus.
                                    </p>",
                        Reviews = @"<h6>Products Reviews</h6>
                                    <p>
                                        Vestibulum ac diam sit amet quam vehicula elementum sed sit amet dui.
                                        Pellentesque in ipsum id orci porta dapibus. Proin eget tortor risus. Vivamus
                                        suscipit tortor eget felis porttitor volutpat. Vestibulum ac diam sit amet quam
                                        vehicula elementum sed sit amet dui. Donec rutrum congue leo eget malesuada.
                                        Vivamus suscipit tortor eget felis porttitor volutpat. Curabitur arcu erat,
                                        accumsan id imperdiet et, porttitor at sem. Praesent sapien massa, convallis a
                                        pellentesque nec, egestas non nisi. Vestibulum ac diam sit amet quam vehicula
                                        elementum sed sit amet dui. Vestibulum ante ipsum primis in faucibus orci luctus
                                        et ultrices posuere cubilia Curae; Donec velit neque, auctor sit amet aliquam
                                        vel, ullamcorper sit amet ligula. Proin eget tortor risus.
                                    </p>
                                    <p>
                                        Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Lorem
                                        ipsum dolor sit amet, consectetur adipiscing elit. Mauris blandit aliquet
                                        elit, eget tincidunt nibh pulvinar a. Cras ultricies ligula sed magna dictum
                                        porta. Cras ultricies ligula sed magna dictum porta. Sed porttitor lectus
                                        nibh. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a.
                                        Vestibulum ac diam sit amet quam vehicula elementum sed sit amet dui. Sed
                                        porttitor lectus nibh. Vestibulum ac diam sit amet quam vehicula elementum
                                        sed sit amet dui. Proin eget tortor risus.
                                    </p>",
                        Unit = unit,
                        Category = category
                    };

                    product.Images = new List<ProductImage>();

                    product.Images.Add(new ProductImage
                    {
                        ImagePath = "product-details-1.jpg",
                        IsMain = true
                    });

                    product.Images.Add(new ProductImage
                    {
                        ImagePath = "thumb-1.jpg",
                        IsMain = false
                    });

                    product.Images.Add(new ProductImage
                    {
                        ImagePath = "thumb-2.jpg",
                        IsMain = false
                    });

                    product.Images.Add(new ProductImage
                    {
                        ImagePath = "thumb-3.jpg",
                        IsMain = false
                    });

                    product.Images.Add(new ProductImage
                    {
                        ImagePath = "thumb-4.jpg",
                        IsMain = false
                    });

                    db.Products.Add(product);

                    db.SaveChanges();
                }
            }
        }

        private static void InitProductUnits(OganiDbContext db)
        {
            if (!db.ProductUnits.Any())
            {
                db.ProductUnits.Add(new ProductUnit
                {
                    Name = "kq",
                    Description = "Kiloqram"
                });

                db.ProductUnits.Add(new ProductUnit
                {
                    Name = "q",
                    Description = "Qram"
                });

                db.ProductUnits.Add(new ProductUnit
                {
                    Name = "l",
                    Description = "Litr"
                });

                db.ProductUnits.Add(new ProductUnit
                {
                    Name = "ml",
                    Description = "Millilitr"
                });

                db.ProductUnits.Add(new ProductUnit
                {
                    Name = "m",
                    Description = "Metr"
                });

                db.ProductUnits.Add(new ProductUnit
                {
                    Name = "sm",
                    Description = "Santimetr"
                });

                db.SaveChanges();
            }

        }

        private static void InitCategories(OganiDbContext db)
        {
			if (!db.Categories.Any())
            {
                db.Categories.Add(new Category
                {
                    Name = "Fresh Onion"
                });
                db.Categories.Add(new Category
                {
                    Name = "Fresh Berries"
                });
                db.Categories.Add(new Category
                {
                    Name = "Vegetables"
                });
                db.Categories.Add(new Category
                {
                    Name = "Fresh Bananas"
                });
                db.Categories.Add(new Category
                {
                    Name = "Fresh Meat"
                });

                db.SaveChanges();
            }
        }
    }
}

