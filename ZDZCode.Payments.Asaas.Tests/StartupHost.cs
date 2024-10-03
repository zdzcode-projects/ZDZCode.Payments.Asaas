using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ZDZCode.Infrastructure.Infrastructure;

namespace ZDZCode.Payments.Asaas.Tests
{
    public class StartupHost : ZCStartupAPI
    {
        public StartupHost(IConfiguration configuration) : base(configuration)
        {
        }

        public override void ConfigureBasicServices(IServiceCollection services)
        {

        }

        public override void ConfigureBusinessServices(IServiceCollection services)
        {
        }

        public override void ConfigureDataAccessServices(IServiceCollection services)
        {
        }

        public override void ConfigureIntegrationServices(IServiceCollection services)
        {
            services.AddScoped<AsaasService>();
        }

        public override void ConfigureMiddleware(IApplicationBuilder app, IWebHostEnvironment env)
        {

        }
    }
}
