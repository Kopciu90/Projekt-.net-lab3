using Xunit;
using Moq;
using System.Collections.Generic;
using eTickets.Data.Services;
using eTickets.Controllers;
using Microsoft.AspNetCore.Mvc;
using eTickets.Models;

public class ActorsControllerTests
{
    [Fact]
    public async Task Index_ReturnsAViewResult_WithAListOfActors()
    {
        // Arrange
        var mockService = new Mock<IActorsService>();
        mockService.Setup(service => service.GetAllAsync())
            .ReturnsAsync(GetTestActors());
        var controller = new ActorsController(mockService.Object);

        // Act
        var result = await controller.Index();

        // Assert
        var viewResult = Assert.IsType<ViewResult>(result);
        var model = Assert.IsAssignableFrom<IEnumerable<Actor>>(
            viewResult.ViewData.Model);
        Assert.Equal(2, model.Count());
    }

    private List<Actor> GetTestActors()
    {
        var actors = new List<Actor>
        {
            new Actor { Id = 1, FullName = "Actor 1" },
            new Actor { Id = 2, FullName = "Actor 2" }
        };
        return actors;
    }
}
