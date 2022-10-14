using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MokshaLamp.Data;

namespace MokshaLamp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MokshaLampContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MokshaLampContext>>()))
            {
                // Look for any movies.
                if (context.Lamp.Any())
                {
                    return;   // DB has been seeded
                }

                context.Lamp.AddRange(
                    new Lamp
                    {
                        Category = "Table Lamps",
                        ManufactureDate = DateTime.Parse("2020-4-22"),
                        Color = "Pink",
                        Material = "Metal",
                        Dimension = 11,
                        Price = 10.99M,
                        Rating = "R"
                    },

                    new Lamp
                    {
                        Category = "Ceiling lights",
                        ManufactureDate = DateTime.Parse("2022-9-12"),
                        Color = "black",
                        Material = "Ceramic",
                        Dimension = 30,
                        Price = 6.78M,
                        Rating = "R"
                    },

                    new Lamp
                    {
                        Category = "Outdoor lights",
                        ManufactureDate = DateTime.Parse("2021-3-30"),
                        Color = "Purple",
                        Material = "Metal",
                        Dimension = 21,
                        Price = 9.99M,
                        Rating = "R"
                    },

                    new Lamp
                    {
                        Category = "Table Lamps",
                        ManufactureDate = DateTime.Parse("2018-8-23"),
                        Color = "Maroon",
                        Material = "Plastic",
                        Dimension = 31,
                        Price = 10.23M,
                        Rating = "R"
                    },

                    new Lamp
                    {
                        Category = "LED Lights",
                        ManufactureDate = DateTime.Parse("2021-5-15"),
                        Color = "Orange",
                        Material = "Glass",
                        Dimension = 7,
                        Price = 4.12M,
                        Rating = "R"
                    },

                    new Lamp
                    {
                        Category = "Chandeliers",
                        ManufactureDate = DateTime.Parse("2017-6-19"),
                        Color = "Blue",
                        Material = "Wood",
                        Dimension = 27,
                        Price = 13.99M,
                        Rating = "R"
                    },

                    new Lamp
                    {
                        Category = "Wall Lights",
                        ManufactureDate = DateTime.Parse("2020-10-29"),
                        Color = "Yellow",
                        Material = "Glass",
                        Dimension = 17,
                        Price = 8.49M,
                        Rating = "R"
                    },

                    new Lamp
                    {
                        Category = "Outdoor Lights",
                        ManufactureDate = DateTime.Parse("2014-5-31"),
                        Color = "Brass",
                        Material = "Metal",
                        Dimension = 19,
                        Price = 12.89M,
                        Rating = "R"
                    },

                    new Lamp
                    {
                        Category = "Ceiling Lights",
                        ManufactureDate = DateTime.Parse("2020-9-15"),
                        Color = "Copper",
                        Material = "Metal",
                        Dimension = 38,
                        Price = 8.99M,
                        Rating = "R"
                    },

                    new Lamp
                    {
                        Category = "Chandeliers",
                        ManufactureDate = DateTime.Parse("2022-1-14"),
                        Color = "Black",
                        Material = "Wood",
                        Dimension = 42,
                        Price = 15.29M,
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
