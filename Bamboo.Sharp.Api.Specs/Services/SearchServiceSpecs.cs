using System.Linq;
using Bamboo.Sharp.Api.Exceptions;
using Bamboo.Sharp.Api.Model;
using Bamboo.Sharp.Api.Services;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bamboo.Sharp.Api.Specs.Services
{
    [TestClass]
    public class SearchServiceSpecs
    {
        [TestMethod]
        public void ShouldGetAUserSearchResult()
        {
            var api = ServiceSpecHelper.Api;
            var service = api.GetService<SearchService>();
            var users = service.SearchUsers("jony", true);

            var enumerable = users as User[] ?? users.ToArray();
            enumerable.Length.Should().BeGreaterOrEqualTo(1);
            enumerable.First().Name.Should().Be("jonytek");
        }

        [TestMethod]
        public void ShouldGetAAuthorSearchResultAsync()
        {
            var api = ServiceSpecHelper.Api;
            var service = api.GetService<SearchService>();
            var users = service.SearchUsersAsync("jony", true).Result;

            var enumerable = users as User[] ?? users.ToArray();
            enumerable.Length.Should().BeGreaterOrEqualTo(1);
            enumerable.First().Name.Should().Be("jonytek");
        }

        [TestMethod]
        public void ShouldGetAAuthorSearchResult()
        {
            var api = ServiceSpecHelper.Api;
            var service = api.GetService<SearchService>();
            var authors = service.SearchAuthors("jony", false);

            authors.Count().Should().BeGreaterOrEqualTo(1);
            authors.First().Name.Should().Be("jony");
            authors.First().AuthorName.Should().Be("jony");
        }

        [TestMethod]
        public void ShouldGetAUserSearchResultAsync()
        {
            var api = ServiceSpecHelper.Api;
            var service = api.GetService<SearchService>();
            var authors = service.SearchAuthorsAsync("jony", false).Result;

            authors.Count().Should().BeGreaterOrEqualTo(1);
            authors.First().Name.Should().Be("jony");
            authors.First().AuthorName.Should().Be("jony");
        }

        [TestMethod]
        public void ShouldGetAPlanSearchResult()
        {
            var api = ServiceSpecHelper.Api;
            var service = api.GetService<SearchService>();
            var plans = service.SearchPlans();

            plans.Count.Should().BeGreaterOrEqualTo(2);
            plans[0].Key.Should().Be("BUILDER-CB");
            plans[0].Type.Should().Be(Type.Chain);
        }

        [TestMethod]
        public void ShouldGetAPlanSearchResultAsync()
        {
            var api = ServiceSpecHelper.Api;
            var service = api.GetService<SearchService>();
            var plans = service.SearchPlansAsync().Result;

            plans.Count.Should().BeGreaterOrEqualTo(2);
            plans[0].Key.Should().Be("BUILDER-CB");
            plans[0].Type.Should().Be(Type.Chain);
        }

        [TestMethod]
        public void ShouldThrowAServerError()
        {
            var api = ServiceSpecHelper.Api;
            var service = api.GetService<SearchService>();
            try
            {
                service.SearchBranches("CxxxxxxxxxxxxxxxxxB");
                Assert.Fail();
            }
            catch (InternalServerError ex)
            {
                ex.StatucCode.Should().Be(500);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void ShouldGetAPlanBranchResult()
        {
            var api = ServiceSpecHelper.Api;
            var service = api.GetService<SearchService>();
            var plans = service.SearchBranches("BUILDER-CB");

            plans.Count.Should().BeGreaterOrEqualTo(1);
            plans[0].Key.Should().Be("BUILDER-CB");
            plans[0].Type.Should().Be(Type.Chain);
        }

        [TestMethod]
        public void ShouldGetAPlanBranchResultAsync()
        {
            var api = ServiceSpecHelper.Api;
            var service = api.GetService<SearchService>();
            var plans = service.SearchBranchesAsync("BUILDER-CB").Result;

            plans.Count.Should().BeGreaterOrEqualTo(1);
            plans[0].Key.Should().Be("BUILDER-CB");
            plans[0].Type.Should().Be(Type.Chain);
        }
    }
}
