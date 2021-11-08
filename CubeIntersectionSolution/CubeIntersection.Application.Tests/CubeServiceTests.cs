using CubeIntersection.Application.Contract.Models;
using CubeIntersection.Application.Contract.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CubeIntersection.Application.Tests
{
    [TestClass]
    public class CubeServiceTests
    {

        private readonly Mock<ICubeService> _mockCubeService;

        public CubeServiceTests()
        {
            _mockCubeService = new Mock<ICubeService>();
        }

        //[TestMethod]
        //public void non_intersecting_cubes()
        //{
        //    Initialization(new PointModel(2, 2, 2 ));

        //    var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
        //    var cubeB = Cube().CenteredAt(10, 10, 10).WithEdgeLength(2).Build();

        //    Assert.IsFalse(cubeA.CollidesWith(cubeB));
        //}

        //[TestMethod]
        //public void cubes_that_overlap()
        //{
        //    var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
        //    var cubeB = Cube().CenteredAt(3, 2, 2).WithEdgeLength(2).Build();

        //    Assert.IsTrue(cubeA.CollidesWith(cubeB));
        //}

        //[TestMethod]
        //public void cubes_that_touch()
        //{
        //    var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
        //    var cubeB = Cube().CenteredAt(4, 2, 2).WithEdgeLength(2).Build();

        //    Assert.IsTrue(cubeA.CollidesWith(cubeB));
        //}
        
        //private PointModel Initialization(PointModel point)
        //{
        //    return  new CubeModel
        //    {
        //        PointCoordinates = PointModelFactory.Create(2, 2, 2)
        //    };

        //    //secondCube = new CubeModel
        //    //{
        //    //    PointCoordinates = PointModelFactory.Create(4, 2, 2)
        //    //};

        //    //edgesLength = 2;

        //    //cubeRequest = new CubeModel
        //    //{
        //    //    FirstCube3D = firstCube3D,
        //    //    SecondCube3D = secondCube3D,
        //    //    EdgesLength = edgesLength
        //    //};
        //}
    }
}
