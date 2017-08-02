using FluentAssertions;
using RMS.IISAgent.Configuration;
using Xunit;

namespace IISAgent.Tests.Configuration
{
    public class AppConfigFileProviderTests
    {
        private readonly IConfigurationProvider configurationProvider;

        public AppConfigFileProviderTests()
        {
            configurationProvider = new AppConfigFileProvider();
        }

        [Fact]
        public void should_return_service_name_from_configuration_file()
        {
            // arrange
            var expectedServiceName = "RmsIISAgent";

            // act
            var actualServiceName = configurationProvider.ServiceName;

            // assert
            actualServiceName.Should().Be(expectedServiceName);
        }

        [Fact]
        public void should_return_service_display_name_from_configuration_file()
        {
            // arrange
            var expectedServiceDisplayName = "RMS-IIS Agent";

            // act
            var actualServiceDisplayName = configurationProvider.ServiceDisplayName;

            // assert
            actualServiceDisplayName.Should().Be(expectedServiceDisplayName);
        }

        [Fact]
        public void should_return_service_description_from_configuration_file()
        {
            // arrange
            var expectedServiceDescription = "Monitors statistics of web applications hosted on IIS server.";

            // act
            var actualServiceDescription = configurationProvider.ServiceDescription;

            // assert
            actualServiceDescription.Should().Be(expectedServiceDescription);
        }

        [Fact]
        public void should_return_value_of_timer_interval_of_iis_monitor_service()
        {
            // arrange
            var expectedTimerInterval = 5000d;

            // act
            var actualTimerInterval = configurationProvider.MonitorTimerInterval;

            // assert
            actualTimerInterval.Should().Be(expectedTimerInterval);
        }
    }
}