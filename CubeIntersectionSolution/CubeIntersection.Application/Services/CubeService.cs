using CubeIntersection.Application.Contract.Models;
using CubeIntersection.Application.Contract.Services;
using System;

namespace CubeIntersection.Application.Services
{
    public class CubeService : ICubeService
    {
        private readonly IEdgeService _edgeService;

        public CubeService(IEdgeService edgeService)
        {
            _edgeService = edgeService ?? throw new ArgumentNullException(nameof(edgeService));
        }

        public double IntersectionVolumeWith(EdgeModel edgeA, EdgeModel edgeB) =>
                _edgeService.Overlap(edgeA, edgeB)
                * _edgeService.Overlap(edgeA, edgeB)
                * _edgeService.Overlap(edgeA, edgeB);

        public bool CollidesWith(EdgeModel edgeA, EdgeModel edgeB) =>
                _edgeService.Collides(edgeA, edgeB)
                || _edgeService.Collides(edgeA, edgeB)
                || _edgeService.Collides(edgeA, edgeB);
    }
}