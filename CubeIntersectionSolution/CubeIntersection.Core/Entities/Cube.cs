namespace CubeIntersection.Core.Entities
{
    public class Cube
    {
        public Edge Width;

        public Edge Height;

        public Edge Depth;

        public Cube(Point center, double edgeLength)
        {
            Width = new Edge(center.X, edgeLength);
            Height = new Edge(center.Y, edgeLength);
            Depth = new Edge(center.Z, edgeLength);
        }
    }
}