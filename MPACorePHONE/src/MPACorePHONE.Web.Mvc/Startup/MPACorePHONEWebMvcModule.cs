using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MPACorePHONE.Configuration;

namespace MPACorePHONE.Web.Startup
{
    [DependsOn(typeof(MPACorePHONEWebCoreModule))]
    public class MPACorePHONEWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MPACorePHONEWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<MPACorePHONENavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MPACorePHONEWebMvcModule).GetAssembly());
        }
    }
}
