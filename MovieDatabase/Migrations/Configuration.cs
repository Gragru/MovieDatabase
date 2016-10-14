
namespace MovieDatabase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MovieDatabase.DataAccessLayer;
    using MovieDatabase.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieDbContext context)
        {
            context.Movies.AddOrUpdate(
                m => m.Title,
            new Movie
            {
                Title = "Return of the killing tomatoes",
                Genre = Genre.Comedy,
                AgeLimit = 15,
                Length = 93,
                MetaScore = 77
            },
            new Movie
            {
                Title = "Programmers Academy XII",
                Genre = Genre.Drama,
                AgeLimit = 12,
                Length = 88,
                MetaScore = 44
            },
            new Movie
            {
                Title = "Finalizer 7",
                Genre = Genre.Action,
                AgeLimit = 15,
                Length = 104,
                MetaScore = 34
            },
            new Movie
            {
                Title = "Lord of the earrings",
                Genre = Genre.Adventure,
                AgeLimit = 7,
                Length = 111,
                MetaScore = 91
            }
            );
        }
    }
}
