using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models {
    public static class SeedData {
        public static void EnsurePopulated (IApplicationBuilder app) {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext> ();
            context.Database.Migrate ();
            if (!context.Products.Any ()) {
                context.Products.AddRange (
                    new Product {
                        Name = "Kayak", Descripiton = "A boat for one person",
                            Category = "Watersports", Price = 275
                    },
                    new Product {
                        Name = "Lifejaket", Descripiton = "Protective and Fashionable",
                            Category = "Watersports", Price = 48.95M
                    },
                    new Product {
                        Name = "Soccer Ball", Descripiton = "Fifa-approved soccer ball",
                            Category = "Soccer", Price = 19.50M
                    },
                    new Product {
                        Name = "Corner Flags", Descripiton = "Give your playing field a professional touch",
                            Category = "Soccer", Price = 34.95M
                    },
                    new Product {
                        Name = "Stadium", Descripiton = "Flat-packed 35,000-seat stadium",
                            Category = "Soccer", Price = 79500
                    },
                    new Product {
                        Name = "Thinking Hat", Descripiton = "Improoves brain efficiency by 75%",
                            Category = "Chess", Price = 16
                    },
                    new Product {
                        Name = "Unsteady Chair", Descripiton = "Secretly give you opponent a disadvantage",
                            Category = "Chess", Price = 29.95M
                    },
                    new Product {
                        Name = "Human Chess Board", Descripiton = "A fun game for the family",
                            Category = "Chess", Price = 75
                    },
                    new Product {
                        Name = "Bling-Bling King", Descripiton = "Gold-plated, diamond-studded King",
                            Category = "Chess", Price = 1200
                    }

                );
                context.SaveChanges();
            }
        }

    }
}