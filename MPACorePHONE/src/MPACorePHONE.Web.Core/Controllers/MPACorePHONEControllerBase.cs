using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MPACorePHONE.Controllers
{
    public abstract class MPACorePHONEControllerBase: AbpController
    {
        protected MPACorePHONEControllerBase()
        {
            LocalizationSourceName = MPACorePHONEConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
