using CubeIntersection.Application.Contract.Models;
using CubeIntersection.Application.Contract.Services;
using CubeIntersection.Infrastructure.Contract.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CubeIntersection.Application.Tests
{
    [TestClass]
    public class CubeServiceTests
    {
        private ICubeService _cubeService;

        public CubeServiceTests()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddServices();
            var serviceProvider = serviceCollection.BuildServiceProvider();

            _cubeService = serviceProvider.GetService<ICubeService>();
        }

        [TestMethod]
        public void no_intersectionVolumeWith()
        {
            EdgeModel edgeA = new EdgeModel
            {
                Start = 1.0,
                End = 2.0
            };

            EdgeModel edgeB = new EdgeModel
            {
                Start = 10.0,
                End = 12.0
            };

            double result = _cubeService.IntersectionVolumeWith(edgeA, edgeB);

            Assert.AreEqual(result, 0.0);
        }

        [TestMethod]
        public void intersectionVolumeWith()
        {
            EdgeModel edgeA = new EdgeModel
            {
                Start = 1.0,
                End = 3.0
            };

            EdgeModel edgeB = new EdgeModel
            {
                Start = 1.0,
                End = 2.0
            };

            double result = _cubeService.IntersectionVolumeWith(edgeA, edgeB);

            Assert.AreNotEqual(result, 0.0);
        }

        [TestMethod]
        public void no_collidesWith()
        {
            EdgeModel edgeA = new EdgeModel
            {
                Start = 1.0,
                End = 1.0
            };

            EdgeModel edgeB = new EdgeModel
            {
                Start = 3.0,
                End = 3.0
            };

            bool result = _cubeService.CollidesWith(edgeA, edgeB);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void collidesWith()
        {
            EdgeModel edgeA = new EdgeModel
            {
                Start = 1.0,
                End = 3.0
            };

            EdgeModel edgeB = new EdgeModel
            {
                Start = 1.0,
                End = 2.0
            };

            bool result = _cubeService.CollidesWith(edgeA, edgeB);

            Assert.IsTrue(result);
        }
    }
}
