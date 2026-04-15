using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using MyProject.Server.Controllers;
using MyProject.Server.Models;
using Xunit;

namespace MyProject.Tests
{
    public class CitizenControllerTests
    {
            [Fact]
            public void Citizen_Should_Create_Correctly()
            {
                var citizen = new Citizen
                {
                    FirstName = "Naruto",
                    LastName = "Uzumaki",
                    Patronim = "Minatovich"
                };

                Assert.Equal("Naruto", citizen.FirstName);
                Assert.Equal("Uzumaki", citizen.LastName);
                Assert.Equal("Minatovich", citizen.Patronim);
        }

    }
}