namespace CubeIntersection.Core.Entities
{
    public class Cube
    {
        private Edge width;

        private Edge height;

        private Edge depth;

        public Cube(Point center, double edgeLength)
        {
            width = new Edge(center.X, edgeLength);
            height = new Edge(center.Y, edgeLength);
            depth = new Edge(center.Z, edgeLength);
        }
    }
}