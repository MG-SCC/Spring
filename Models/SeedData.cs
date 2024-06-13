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
                    Material = "Natural",
                    Price = 799M
                    Rating = 4
                },
                new Furniture
                {
                    Name = "Sleepwell ",
                    Colour = "Floral",
                    Type = "Mattress",
                    Material = "Synthetic,"
                    Price = 899M
                    Rating = 4
                },
                new Furniture
                {
                    Name = "Family Diner",
                    Colour = "Oak",
                    Type = "Table",
                    Material = "Natural",
                    Price = 999M
                    Rating = 3
                },
                new Furniture
                {
                    Name = "Hide and Sleep",
                    Colour = "Red",
                    Type = "Sofa Bed",
                    Material = "Synthetic",
                    Price = 399M
                    Rating = 5
                }

				new Furniture
				{
					Name = "Soft Rocker",
					Colour = "Oak",
					Type = "Rocking Chair",
					Material = "Synthetic",
					Price = 399M

					Rating = 5
				}

				new Furniture
				{
					Name = "College Deluxe",
					Colour = "Beige",
					Type = "Futon",
					Material = "Natural",
					Price = 399M

					Rating = 5
				}

				new Furniture
				{
					Name = "Home and Chill",
					Colour = "Black",
					Type = "Sofa",
					Material = "Natural",
					Price = 399M

					Rating = 3
				}

				new Furniture
				{
					Name = "Store More",
					Colour = "Teal",
					Type = "Dresser",
					Material = "Natural",
					Price = 799M

					Rating = 5
				}
				{
				Name = "Sleep Away",
					Colour = "Floral",
					Type = "Mattress",
					Material = "Natural",
					Price = 1199M

					Rating = 2
				}
			{
				Name = "Kitchen Classic",
					Colour = "Pine",
					Type = "Chair",
					Material = "Natural",
					Price = 199M

					Rating = 5
				}
			);
            context.SaveChanges();
        }
    }
}