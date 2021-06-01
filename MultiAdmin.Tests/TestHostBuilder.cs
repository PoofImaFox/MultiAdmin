using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Moq;

using MultiAdmin.Extensions.HostBuilder;

using Xunit;

namespace MultiAdmin.Tests
{
	public class TestHostBuilder
	{
		[Fact]
		public void TestStartupExtension()
		{
			var mockedStartup = new Mock<IStartup>();

			Host.CreateDefaultBuilder(Array.Empty<string>())
				.UseStartup(mockedStartup.Object)
				.Build();

			mockedStartup.Verify(i => i.Configure(It.IsAny<HostBuilderContext>(), It.IsAny<IConfigurationBuilder>()), Times.Once);
			mockedStartup.Verify(i => i.ConfigureServices(It.IsAny<HostBuilderContext>(), It.IsAny<IServiceCollection>()), Times.Once);
		}
	}
}
