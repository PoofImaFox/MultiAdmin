using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;

namespace MultiAdmin.Extensions.HostBuilder
{
	public static class HostBuilderExtension
	{
		public static IHostBuilder UseStartup<T>(this IHostBuilder hostBuilder) where T : IStartup, new()
		{
			IStartup startup = new T();
			return UseStartup(hostBuilder, startup);
		}

		public static IHostBuilder UseStartup(this IHostBuilder hostBuilder, IStartup startup)
		{
			hostBuilder.ConfigureAppConfiguration(startup.Configure);
			hostBuilder.ConfigureServices(startup.ConfigureServices);

			return hostBuilder;
		}
	}
}