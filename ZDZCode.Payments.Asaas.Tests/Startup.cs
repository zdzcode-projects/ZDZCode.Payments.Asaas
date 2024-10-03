using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ZDZCode.Payments.Asaas.Tests
{
    public class Startup : ZC.Tests.Core.ZCStartupIntegrationTest<StartupHost>
    {
        public override string EnvironmentName => "Staging";

        public override void ConfigureAppConfiguration(WebHostBuilderContext hostingContext, IConfigurationBuilder configurationBuilder)
        {
        }

        public override void ConfigureTestServices(IServiceCollection services, HostBuilderContext context)
        {

        }
    }
}
