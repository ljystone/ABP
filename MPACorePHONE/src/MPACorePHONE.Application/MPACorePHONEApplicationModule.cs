using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MPACorePHONE.Authorization;

namespace MPACorePHONE
{
    [DependsOn(
        typeof(MPACorePHONECoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MPACorePHONEApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MPACorePHONEAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MPACorePHONEApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
