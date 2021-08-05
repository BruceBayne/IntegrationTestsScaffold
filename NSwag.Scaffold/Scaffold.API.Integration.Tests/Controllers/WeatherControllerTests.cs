using System.Threading.Tasks;
using FluentAssertions;
using Scaffold.API.Integration.Tests.Base;
using Xunit;

namespace Scaffold.API.Integration.Tests.Controllers
{
	public sealed class WeatherControllerTests : BaseIntegrationTests
	{
		public WeatherControllerTests(ScaffoldApiFixture application) : base(application)
		{
		}


		[Fact]
		public async Task WeatherForecast_Works()
		{
			//ARRANGE


			//ACT 
			var weather = await Client.WeatherForecast_GetAsync();


			//ASSERT
			weather.Count.Should().Be(5);
			weather.Should().OnlyContain(x => !string.IsNullOrEmpty(x.Summary));
		}
	}
}