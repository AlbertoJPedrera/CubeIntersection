using CubeIntersection.Application.Contract.Models;
using System;

namespace CubeIntersection.Application.Services
{
    public class EdgeService
    {
        public double Overlap(EdgeModel edgeA, EdgeModel edgeB) => Math.Max(0, Difference(edgeA, edgeB));

        public bool Collides(EdgeModel edgeA, EdgeModel edgeB) => Difference(edgeA, edgeB) >= 0;

        private double Difference(EdgeModel edgeA, EdgeModel edgeB) => Math.Min(edgeA.End, edgeB.End) - Math.Max(edgeA.Start, edgeB.Start);
    }
}