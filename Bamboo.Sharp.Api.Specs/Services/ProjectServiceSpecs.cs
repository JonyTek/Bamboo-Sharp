using System.Linq;
using Bamboo.Sharp.Api.Services;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bamboo.Sharp.Api.Specs.Services
{
    [TestClass]
    public class ProjectServiceSpecs
    {
        [TestMethod]
        public void ShouldGetAllProjects()
        {
            var api = ServiceSpecHelper.Api;
            var endpoint = api.GetService<ProjectService>();
            var projects = endpoint.GetProjects();

            projects.All.Count().Should().BeGreaterOrEqualTo(2);
        }

        [TestMethod]
        public void ShouldGetAllProjectsAsync()
        {
            var api = ServiceSpecHelper.Api;
            var endpoint = api.GetService<ProjectService>();
            var projects = endpoint.GetProjectsAsync();

            projects.Result.All.Count().Should().BeGreaterOrEqualTo(2);
        }

        [TestMethod]
        public void ShouldGetProject()
        {
            var api = ServiceSpecHelper.Api;
            var endpoint = api.GetService<ProjectService>();
            var project = endpoint.GetProject("CMSBUIL");

            project.Key.Should().Be("CMSBUIL");
            project.Name.Should().Be("Cms.Builder.Api");
            project.Link.Should().NotBeNull();
        }

        [TestMethod]
        public void ShouldGetAProjectAsync()
        {
            var api = ServiceSpecHelper.Api;
            var endpoint = api.GetService<ProjectService>();
            var project = endpoint.GetProjectAsync("CMSBUIL").Result;

            project.Key.Should().Be("CMSBUIL");
            project.Name.Should().Be("Cms.Builder.Api");
            project.Link.Should().NotBeNull();
        }

        [Ignore]
        [TestMethod]
        public void ShouldCloneAProject()
        {
            const string fromProjKey = "TEMP";
            const string fromBuildKey = "TEMP";
            const string newProjKey = "BUILDER";
            const string newBuildKey = "CB1";

            var api = ServiceSpecHelper.Api;
            var endpoint = api.GetService<ProjectService>();
            var plan = endpoint.Clone(fromProjKey, fromBuildKey, newProjKey, newBuildKey);
        }

        [Ignore]
        [TestMethod]
        public void ShouldCloneAProjectAsync()
        {
            const string fromProjKey = "TEMP";
            const string fromBuildKey = "TEMP";
            const string newProjKey = "BUILDER";
            const string newBuildKey = "CB1";

            var api = ServiceSpecHelper.Api;
            var endpoint = api.GetService<ProjectService>();
            var plan = endpoint.CloneAsync(fromProjKey, fromBuildKey, newProjKey, newBuildKey).Result;
        }
    }
}

