using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "17 Miracles",
                    ReleaseDate = DateTime.Parse("2011-3-6"),
                    Genre = "Drama",
                    Rating = "PG",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Forever Strong",
                    ReleaseDate = DateTime.Parse("2008-26-10"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "The Saratov Approach",
                    ReleaseDate = DateTime.Parse("2013-9-10"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Charly",
                    ReleaseDate = DateTime.Parse("2002-4-15"),
                    Genre = "Romance",
                    Rating = "PG-13",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}