using System;
using Bamboo.Sharp.Api.Services;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bamboo.Sharp.Api.Specs.Services
{
    [TestClass]
    public class CurrentUserServiceSpecs
    {
        [TestMethod]
        public void ShouldAuthenticateAndReturnTheCurrentUser()
        {
            var api = ServiceSpecHelper.Api;
            var endpoint = api.GetService<CurrentUserService>();
            var user = endpoint.GetUser();

            user.FullName.Should().Be("jonathon swieboda");
            user.Email.Should().Be("jonathontek@gmail.com");
            user.Name.Should().Be("jonytek");
        }

        [TestMethod]
        public void ShouldThrowUnauthorizedException()
        {
            var api = new BambooApi(
                "http://192.168.56.1:8085/rest/api/latest",
                "xxx",
                "xxx");

            var endpoint = api.GetService<CurrentUserService>();
            Action action = () => endpoint.GetUser();

            action.Should().Throw<UnauthorizedAccessException>();
        }

        [TestMethod]
        public void ShouldAuthenticateAndReturnTheCurrentUserAsync()
        {
            var api = ServiceSpecHelper.Api;
            var endpoint = api.GetService<CurrentUserService>();
            var user = endpoint.GetUserAsync().Result;

            user.FullName.Should().Be("jonathon swieboda");
            user.Email.Should().Be("jonathontek@gmail.com");
            user.Name.Should().Be("jonytek");
        }
    }
}
