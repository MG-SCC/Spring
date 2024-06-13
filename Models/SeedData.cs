using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Spring.Data;
using System;
using System.Linq;

namespace Spring.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new SpringContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<SpringContext>>()))
        {
            // Look for any furniture.
            if (context.Furniture.Any())
            {
                return;   // DB has been seeded
            }
            context.Furniture.AddRange(
                new Furniture
                {
                    Name = "Comfort Seat",
                    Colour = "Blue",
                    Type = "Recliner",
                    Price = 799M
                },
                new Furniture
                {
                    Name = "Sleepwell ",
                    Colour = "Floral",
                    Type = "Mattress",
                    Price = 899M
                },
                new Furniture
                {
                    Name = "Family Diner",
                    Colour = "Oak",
                    Type = "Table",
                    Price = 999M
                },
                new Furniture
                {
                    Title = "Hide and Sleep",
                    Colour = "Red",
                    Type = "Sofa Bed",
                    Price = 399M
                }
            );
            context.SaveChanges();
        }
    }
}