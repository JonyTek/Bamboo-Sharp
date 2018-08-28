using Bamboo.Sharp.Api.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bamboo.Sharp.Api.Specs.Services
{
    [TestClass]
    public class QueueServiceSpecs
    {
        [TestMethod]
        public void QueuePlanReturnsQueueResult()
        {
            //Arrange
            var api = new BambooApi("base url", "username", "password");

            //Act
            var sut = api.GetService<QueueService>().QueuePlan("TP-TEST");

            //Assert
            Assert.IsNotNull(sut);
        }

        [TestMethod]
        public void GetResultForQueuedBuild()
        {
            //Arrange
            var api = new BambooApi("base url", "username", "password");
            var queueResult = api.GetService<QueueService>().QueuePlan("TP-TEST");

            //Act
            var sut = api.GetService<QueueService>().GetResultForQueuedPlan(queueResult);

            //Assert
            Assert.IsNotNull(sut);
        }
    }
}