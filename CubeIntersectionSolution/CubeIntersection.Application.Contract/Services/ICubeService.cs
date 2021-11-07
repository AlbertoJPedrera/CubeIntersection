using CubeIntersection.Application.Contract.Models;

namespace CubeIntersection.Application.Contract.Services
{
    public interface ICubeService
    {
        double IntersectionVolumeWith(EdgeModel edgeA, EdgeModel edgeB);

        bool CollidesWith(EdgeModel edgeA, EdgeModel edgeB);
    }
}