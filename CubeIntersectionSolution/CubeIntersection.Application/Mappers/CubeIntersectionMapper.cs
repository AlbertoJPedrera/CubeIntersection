using AutoMapper;
using CubeIntersection.Application.Contract.Models;
using CubeIntersection.Core.Entities;

namespace CubeIntersection.Application.Mappers
{
    public class CubeIntersectionMapper : Profile
    {
        public CubeIntersectionMapper()
        {
            CreateMap<Cube, CubeModel>().ReverseMap();
            CreateMap<Point, PointModel>().ReverseMap();
            CreateMap<Edge, EdgeModel>().ReverseMap();
        }
    }
}