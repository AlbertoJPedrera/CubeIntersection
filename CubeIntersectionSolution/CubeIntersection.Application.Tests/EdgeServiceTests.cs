using CubeIntersection.Application.Contract.Models;
using CubeIntersection.Application.Contract.Services;
using CubeIntersection.Infrastructure.Contract.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeIntersection.Application.Tests
{
    [TestClass]
    public class EdgeServiceTests
    {
        private IEdgeService _edgeService;

        public EdgeServiceTests()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddServices();
            var serviceProvider = serviceCollection.BuildServiceProvider();

            _edgeService = serviceProvider.GetService<IEdgeService>();
        }

        [TestMethod]
        public void not_overlap()
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

            double result = _edgeService.Overlap(edgeA, edgeB);

            Assert.AreEqual(result, 0.0);
        }

        [TestMethod]
        public void overlap()
        {
            EdgeModel edgeA = new EdgeModel
            {
                Start = 1.0,
                End = 2.0
            };

            EdgeModel edgeB = new EdgeModel
            {
                Start = 1.0,
                End = 3.0
            };

            double result = _edgeService.Overlap(edgeA, edgeB);

            Assert.AreNotEqual(result, 0.0);
        }

        [TestMethod]
        public void not_collides()
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

            bool result = _edgeService.Collides(edgeA, edgeB);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void collides()
        {
            EdgeModel edgeA = new EdgeModel
            {
                Start = 1.0,
                End = 2.0
            };

            EdgeModel edgeB = new EdgeModel
            {
                Start = 1.0,
                End = 3.0
            };

            bool result = _edgeService.Collides(edgeA, edgeB);

            Assert.IsTrue(result);
        }
    }
}