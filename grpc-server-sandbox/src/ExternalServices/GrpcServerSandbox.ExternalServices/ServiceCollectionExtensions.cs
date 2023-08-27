using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GrpcServerSandbox.ExternalServices;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddExternalServices(this IServiceCollection serviceCollection,
		IConfiguration configuration)
	{
		return serviceCollection;
	}
}