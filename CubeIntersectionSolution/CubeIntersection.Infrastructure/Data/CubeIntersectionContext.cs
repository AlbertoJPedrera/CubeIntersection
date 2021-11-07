using Microsoft.EntityFrameworkCore;

namespace CubeIntersection.Infrastructure.Data
{
    public class CubeIntersectionContext : DbContext
    {
        public CubeIntersectionContext(DbContextOptions<CubeIntersectionContext> options)
            : base(options)
        {
        }
    }
}
