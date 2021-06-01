using System;

using Microsoft.Extensions.Hosting;

using MultiAdmin.Extensions.HostBuilder;

namespace MultiAdmin
{
	public class Program
	{
		static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args)
		{
			return Host.CreateDefaultBuilder(args)
					.UseStartup<Startup>();
		}
	}
}