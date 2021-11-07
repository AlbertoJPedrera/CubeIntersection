namespace CubeIntersection.Core.Entities
{
    public class Edge
    {
        private double Start;

        private double End;

        public double PointCenter { get; set; }

        public double Length { get; set; }

        public Edge(double center, double length)
        {
            Start = center - length / 2.0;
            End = center + length / 2.0;
            PointCenter = center;
            Length = length;
        }
    }
}