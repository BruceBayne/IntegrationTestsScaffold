using FluentAssertions;
using FluentAssertions.Extensions;
using Scaffold.API.Client.Dto;
using Xunit;

namespace Scaffold.API.Integration.Tests.Units
{
	[Trait("Category", "UnitTests")]
	public sealed class UnitTestsSample
	{
		[Fact]
		public void RecordEquals()
		{
			var w = new WeatherForecastDto() { Date = 10.May(2022) };
			var n = w with { Date = 10.May(2022) };

			n.Should().Be(w);
		}
	}
}