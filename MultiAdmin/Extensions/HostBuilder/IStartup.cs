using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MultiAdmin.Extensions.HostBuilder
{
	public interface IStartup
	{
		void Configure(HostBuilderContext hostBuilderContext, IConfigurationBuilder configurationBuilder);
		void ConfigureServices(HostBuilderContext hostBuilderContext, IServiceCollection services);
	}
}