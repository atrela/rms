using FluentAssertions;
using Microsoft.Web.Administration;
using System;

namespace IISAgent.Core.Tests.WebServer
{
    public class IISServerTests
    {
        //[Fact]
        public void should_connect_to_remote_instance_of_iis_server()
        {
            //// arrange
            //var iis = new IISServer();
            ////iis.Connect();

            //iis.Connect(TestServerConfigurationProvider.RemoteServerIp);

            //IEnumerable<WebApp> apps;
            //// act
            //Action getRunningApps = () => apps = iis.RunningApps;

            //// assert
            //getRunningApps.ShouldNotThrow<System.Runtime.InteropServices.COMException>();

            // arrange
            ServerManager serverManager;

            // act
            serverManager = new ServerManager();

            ApplicationPoolCollection appPools;
            Action getAppPools = () => appPools = serverManager.ApplicationPools;

            // assert
            getAppPools.ShouldNotThrow<System.Runtime.InteropServices.COMException>();
            getAppPools.ShouldNotThrow<UnauthorizedAccessException>();
        }
    }
}