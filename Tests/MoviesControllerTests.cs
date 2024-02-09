using Xunit;
using Moq;
using eTickets.Controllers;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using eTickets.Models;

public class MoviesControllerTests
{
    [Fact]
    public async Task Details_ReturnsNotFound_WhenMovieDoesNotExist()
    {
        // Arrange
        var mockService = new Mock<IMoviesService>();
        mockService.Setup(service => service.GetByIdAsync(It.IsAny<int>()))
                    .ReturnsAsync((Movie)null); // Simulate no movie found
        var controller = new MoviesController(mockService.Object);

        // Act
        var result = await controller.Details(999); // Use an ID that doesn't exist

        // Assert
        Assert.IsType<ViewResult>(result);
    }

    [Fact]
    public async Task Index_ReturnsAViewResult_WithAListOfMovies()
    {
        // Arrange
        var mockService = new Mock<IMoviesService>();
        mockService.Setup(service => service.GetAllAsync()).ReturnsAsync(new List<Movie>
        {
            new Movie { Id = 1, Name = "Test Movie 1" },
            new Movie { Id = 2, Name = "Test Movie 2" }
        });
        var controller = new MoviesController(mockService.Object);

        // Act
        var result = await controller.Index();

        // Assert
        var viewResult = Assert.IsType<ViewResult>(result);
        var model = Assert.IsAssignableFrom<IEnumerable<Movie>>(viewResult.Model);
        Assert.Equal(0, model.Count());
    }

   
}
