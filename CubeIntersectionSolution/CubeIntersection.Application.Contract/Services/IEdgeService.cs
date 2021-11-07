using CubeIntersection.Application.Contract.Models;

namespace CubeIntersection.Application.Contract.Services
{
    public interface IEdgeService
    {
        double Overlap(EdgeModel edge, EdgeModel edgeB);

        bool Collides(EdgeModel edgeA, EdgeModel edgeB);
    }
}