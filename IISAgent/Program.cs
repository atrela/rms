using AutoMapper;
using RMS.IISAgent.Configuration;
using RMS.IISAgent.Core.Web;
using RMS.IISAgent.Data.Service;
using RMS.IISAgent.Monitoring;
using System.Reflection;
using Topshelf;

namespace RMS.IISAgent
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static void Main()
        {
            var container = BootstrapDIContainer();

            RegisterMappings();

            HostFactory.Run(host =>
            {
                host.Service<IService>(svc =>
                {
                    svc.ConstructUsing(name => container.Resolve<IService>());
                    svc.WhenStarted(s => s.Start());
                    svc.WhenStopped(s => s.Stop());
                    svc.WhenPaused(s => s.Pause());
                    svc.WhenShutdown(s => s.Shutdown());
                    svc.WhenContinued(s => s.Continue());
                });

                var configuration = container.Resolve<Configuration.IConfigurationProvider>();

                host.RunAsLocalSystem();
                host.SetServiceName(configuration.ServiceName);
                host.SetDisplayName(configuration.ServiceDisplayName);
                host.SetDescription(configuration.ServiceDescription);
            });
        }

        private static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfiles(Assembly.GetEntryAssembly());
            });
        }

        private static TinyIoC.TinyIoCContainer BootstrapDIContainer()
        {
            var container = TinyIoC.TinyIoCContainer.Current;
            container.Register<Configuration.IConfigurationProvider, AppConfigFileProvider>();
            container.Register<IService, IISService>();
            container.Register<IWebServer, IISServer>();
            container.Register<IGatewayClient, GatewayClient>();
            return container;
        }
    }
}