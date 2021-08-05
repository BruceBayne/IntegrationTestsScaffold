using Deep.Api.Client;
using Xunit;

namespace Scaffold.API.Integration.Tests.Base
{
	[Collection(nameof(ScaffoldApiFixture))]
	[Trait("Category", "Integration")]
	public abstract class BaseIntegrationTests : IClassFixture<ScaffoldApiFixture>
	{
		protected readonly ScaffoldApiFixture Application;
		protected readonly ScaffoldApiClient Client;

		protected BaseIntegrationTests(ScaffoldApiFixture application)
		{
			Application = application;
			Client = new ScaffoldApiClient(ScaffoldApiFixture.url);
		}
	}
}