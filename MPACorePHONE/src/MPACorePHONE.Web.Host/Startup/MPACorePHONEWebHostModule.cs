using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MPACorePHONE.Configuration;

namespace MPACorePHONE.Web.Host.Startup
{
    [DependsOn(
       typeof(MPACorePHONEWebCoreModule))]
    public class MPACorePHONEWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MPACorePHONEWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MPACorePHONEWebHostModule).GetAssembly());
        }
    }
}
