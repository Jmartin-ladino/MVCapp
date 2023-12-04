using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCapp.Data;
using System;
using System.Linq;


namespace MVCapp.Models
{
    public static class SetData
    {   public static void Initialize(IServiceProvider serviceProvider) 
        {
            using (var context = new MVCappContext(
            serviceProvider.GetRequiredService<DbContextOptions<MVCappContext>>()))
            {   //Look for any movies
                if (context.Movie.Any()) return;

                context.Movie.AddRange(
                    new Movie 
                    {
                        Title = "When Harry Met Sally",
                        releaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99m,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "GhostBusters",
                        releaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99m,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "GhostBusters 2",
                        releaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99m,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        releaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99m,
                        Rating = "R"
                    }

                    );
                context.SaveChanges();
            }

        } 
        
    }
}
