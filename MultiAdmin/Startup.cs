using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using MultiAdmin.Extensions.HostBuilder;

namespace MultiAdmin
{
	public class Startup : IStartup
	{
		public void Configure(HostBuilderContext hostBuilderContext, IConfigurationBuilder configurationBuilder)
		{

		}

		public void ConfigureServices(HostBuilderContext hostBuilderContext, IServiceCollection services)
		{

		}
	}
}