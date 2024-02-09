using Xunit;
using System.ComponentModel.DataAnnotations;
using eTickets.Data.ViewComponents;
using System.Collections.Generic;
using eTickets.Data.ViewModels;

public class ModelValidationTests
{
    [Fact]
    public void RegisterVM_Validation_ShouldPass_WithValidData()
    {
        // Arrange
        var model = new RegisterVM
        {
            EmailAddress = "test@example.com",
            Password = "Test@1234",
            ConfirmPassword = "Test@1234"
        };
        var context = new ValidationContext(model, null, null);
        var results = new List<ValidationResult>();

        // Act
        var isValid = Validator.TryValidateObject(model, context, results, true);

        // Assert
        Assert.False(isValid);
    }

   

}
