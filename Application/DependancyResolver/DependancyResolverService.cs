using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependancyResolver;

public static class DependancyResolverService
{
    public static void RegisterApplicationLayer(IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
    }
}