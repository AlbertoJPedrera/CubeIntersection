using CubeIntersection.Application.Contract.Services;
using CubeIntersection.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CubeIntersection.Infrastructure.Contract.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
        {
            // Add Application Layer
            serviceCollection.AddScoped<ICubeService, CubeService>();
            serviceCollection.AddScoped<IEdgeService, EdgeService>();

            return serviceCollection;
        }
    }
}
