using Xunit;
using Moq;
using System.Collections.Generic;
using eTickets.Data.Services;
using eTickets.Controllers;
using Microsoft.AspNetCore.Mvc;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using eTickets.Data;



public class MoviesServiceTests
{
    [Fact]
    public async Task GetMovieByIdAsync_ReturnsMovie_WhenMovieExists()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "MovieDbTest")
            .Options;

        // Insert seed data into the database using one instance of the context
        using (var context = new AppDbContext(options))
        {
            context.Movies.Add(new Movie { Id = 1, Name = "Test Movie" });
            context.SaveChanges();
        }

        // Use a clean instance of the context to run the test
        using (var context = new AppDbContext(options))
        {
            var service = new MoviesService(context);

            // Act
            var movie = await service.GetByIdAsync(1);

            // Assert
            Assert.NotNull(movie);
            Assert.Equal("Test Movie", movie.Name);
        }
        [Fact]
         async Task GetAllAsync_ReturnsAllMovies()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

            var testData = new List<Movie>
        {
            new Movie { Id = 1, Name = "Movie 1" },
            new Movie { Id = 2, Name = "Movie 2" }
        };

            using (var context = new AppDbContext(options))
            {
                context.Movies.AddRange(testData);
                context.SaveChanges();
            }

            using (var context = new AppDbContext(options))
            {
                var service = new MoviesService(context);
                var movies = await service.GetAllAsync();

                Assert.Equal(2, movies.Count());
                Assert.Contains(movies, m => m.Name == "Movie 1");
                Assert.Contains(movies, m => m.Name == "Movie 2");
            }
        }
        }
}
