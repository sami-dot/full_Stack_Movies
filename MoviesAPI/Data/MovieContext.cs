using System;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Entities;
namespace MoviesAPI.Data;

public class MovieContext(DbContextOptions<MovieContext> options) : DbContext(options)
{
    public DbSet<Movie> Movies {get; set;}

    public DbSet<Genre> Genres {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
            new Genre{ Id = 1, Name = "Action"},
            new Genre{ Id = 2, Name = "Sci-Fi"},
            new Genre{ Id = 3, Name = "Fantasy"},
            new Genre{ Id = 4, Name = "Horror"},
            new Genre{ Id = 5, Name = "Romance"}
        );

        modelBuilder.Entity<Movie>().HasData(
            new Movie{Id = 1, Name = "Inception", GenreId = 1, Price = 12.99M, ReleaseDate = new DateOnly(2003,1,1)},
            new Movie{Id = 2, Name = "KingsMan", GenreId = 1, Price = 22.99M, ReleaseDate = new DateOnly(2014,2,2)},
            new Movie{Id = 3, Name = "The Dark Knight", GenreId = 2, Price = 12.99M, ReleaseDate = new DateOnly(2008,1,1)},
            new Movie{Id = 4, Name = "Deadpool", GenreId = 2, Price = 32.99M, ReleaseDate = new DateOnly(2016,1,1)},
            new Movie{Id = 5, Name = "Titanic", GenreId = 5, Price = 12.99M, ReleaseDate = new DateOnly(1999,1,1)},
            new Movie{Id = 6, Name = "The Matrix", GenreId = 2, Price = 9.99M, ReleaseDate = new DateOnly(1998,1,1)});
    }


}
