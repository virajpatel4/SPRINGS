using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcSprings.Data;
using System;
using System.Linq;

namespace MvcSprings.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcSpringsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcSpringsContext>>()))
            {
                // Look for any movies.
                if (context.Spring.Any())
                {


                    context.Spring.AddRange(
                        new Spring
                        {
                            Model = 2578,
                            Color = "Black",
                            Material = "Aluminium",
                            ManufacturingDate = DateTime.Parse("2022-2-12"),
                            Price = 15,
                            IndustryName = "Swastik Firms"
                        },

                         new Spring
                         {
                             Model = 4561,
                             Color = "Cyan",
                             Material = "Steel",
                             ManufacturingDate = DateTime.Parse("2022-12-5"),
                             Price = 26,
                             IndustryName = "Supreme"
                         },

                         new Spring
                         {
                             Model = 1478,
                             Color = "Silver",
                             Material = "Hard Steel",
                             ManufacturingDate = DateTime.Parse("2022-5-2"),
                             Price = 74,
                             IndustryName = "Kailas Titans"
                         },

                         new Spring
                         {
                             Model = 3698,
                             Color = "Violet",
                             Material = "Copper",
                             ManufacturingDate = DateTime.Parse("2021-8-14"),
                             Price = 23,
                             IndustryName = "Cargo"
                         },

                         new Spring
                         {
                             Model = 3256,
                             Color = "light Grey",
                             Material = "Stainless Steel",
                             ManufacturingDate = DateTime.Parse("2022-1-25"),
                             Price = 7.99M,
                             IndustryName = "Fibonaci"
                         },


                         new Spring
                         {
                             Model = 7531,
                             Color = "Romantic Comedy",
                             Material = "Carbon",
                             ManufacturingDate = DateTime.Parse("1989-2-12"),
                             Price = 7.99M,
                             IndustryName = "Zilias"
                         },

                         new Spring
                         {
                             Model = 1236,
                             Color = "lavender",
                             Material = "Chrome",
                             ManufacturingDate = DateTime.Parse("2022-12-9"),
                             Price = 69,
                             IndustryName = "Britania"
                         },
                         new Spring
                         {
                             Model = 7896,
                             Color = "Black",
                             Material = "Steel",
                             ManufacturingDate = DateTime.Parse("2021-7-8"),
                             Price = 58,
                             IndustryName = "Big Boys"
                         },



                         new Spring
                         {
                             Model = 3698,
                             Color = "Black",
                             Material = "Zinc",
                             ManufacturingDate = DateTime.Parse("2020-6-22"),
                             Price = 66,
                             IndustryName = "Premium Works"
                         },

                         new Spring
                         {
                             Model = 4563,
                             Color = "Grey",
                             Material = "Silver",
                             ManufacturingDate = DateTime.Parse("2021-7-5"),
                             Price = 74,
                             IndustryName = "Axel",
                         }

                         );
                     context.SaveChanges();
            }
                return;   // DB has been seeded
            }
        }
    }
}
