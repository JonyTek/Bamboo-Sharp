using System.Collections;
using System.Collections.Generic;
using Bamboo.Sharp.Api.Deserializers;
using Bamboo.Sharp.Api.Specs.Properties;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace Bamboo.Sharp.Api.Specs.Deserializers
{
    [TestClass]
    public class ProjectsDeserializerSpecs
    {
        //[TestMethod]
        //public void ShouldDeserializeProjects()
        //{
        //    var deserializer = new ProjectsDeserializer();
        //    var response = new RestResponse {Content = Resources.ProjectsJson};
        //    var projects = deserializer.Deserialize(response);

        //    projects.Count.Should().Be(2);
        //    projects[0].Name.Should().Be("Cms.Builder.Api");
        //    projects[0].Plans.All[0].ProjectKey.Should().Be("CMSBUIL");
        //    projects[0].Plans.All[0].Actions.All[0].Name.Should().Be("READ");
        //}
    }
}
