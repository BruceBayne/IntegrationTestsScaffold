using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Scaffold.API.Integration.Tests.Base
{
	public sealed class ScaffoldApiFixture : IDisposable
	{
		public const string Url = "http://localhost:54318";
		private readonly IWebHost host;

		public ScaffoldApiFixture()
		{
			host = WebHost.CreateDefaultBuilder()
				.UseEnvironment("Development")
				.UseStartup<Startup>()
				.UseKestrel()
				.UseUrls(Url)
				.Build();
			host.Start();
		}

		public void Dispose()
		{
			host?.Dispose();
		}
	}
}