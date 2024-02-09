using Xunit;
using Moq;
using eTickets.Controllers;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public class CinemasControllerTests
{
    [Fact]
    public async Task Index_ReturnsAViewResult_WithAListOfCinemas()
    {
        // Arrange
        var mockService = new Mock<ICinemasService>();
        mockService.Setup(service => service.GetAllAsync()).ReturnsAsync(new List<Cinema>
        {
            new Cinema { Id = 1, Name = "Cinema 1" },
            new Cinema { Id = 2, Name = "Cinema 2" }
        });
        var controller = new CinemasController(mockService.Object);

        // Act
        var result = await controller.Index();

        // Assert
        var viewResult = Assert.IsType<ViewResult>(result);
        var model = Assert.IsAssignableFrom<IEnumerable<Cinema>>(viewResult.Model);
        Assert.Equal(2, model.Count());
    }
    [Fact]
    public async Task Details_ReturnsFound_WhenCinemaDoesNotExist()
    {
        // Arrange
        var mockService = new Mock<ICinemasService>();
        mockService.Setup(service => service.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Cinema)null);
        var controller = new CinemasController(mockService.Object);

        // Act
        var result = await controller.Details(999); // Non-existent cinema ID

        // Assert
        Assert.IsType<ViewResult>(result);
    }

    [Fact]
    public async Task Details_ReturnsViewWithCinema_WhenCinemaExists()
    {
        // Arrange
        var mockService = new Mock<ICinemasService>();
        mockService.Setup(service => service.GetByIdAsync(1))
                   .ReturnsAsync(new Cinema { Id = 1, Name = "Cinema 1" });
        var controller = new CinemasController(mockService.Object);

        // Act
        var result = await controller.Details(1);

        // Assert
        var viewResult = Assert.IsType<ViewResult>(result);
        var model = Assert.IsType<Cinema>(viewResult.Model);
        Assert.Equal(1, model.Id);
        Assert.Equal("Cinema 1", model.Name);
    }
    [Fact]
    public async Task Create_Post_RedirectsToIndex_WithValidModel()
    {
        // Arrange
        var mockService = new Mock<ICinemasService>();
        var controller = new CinemasController(mockService.Object);
        var newCinema = new Cinema { Name = "New Cinema" };

        // Act
        var result = await controller.Create(newCinema);

        // Assert
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("Index", redirectToActionResult.ActionName);
        mockService.Verify(s => s.AddAsync(It.IsAny<Cinema>()), Times.Once);
    }

}
