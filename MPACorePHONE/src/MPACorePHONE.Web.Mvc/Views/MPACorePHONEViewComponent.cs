using Abp.AspNetCore.Mvc.ViewComponents;

namespace MPACorePHONE.Web.Views
{
    public abstract class MPACorePHONEViewComponent : AbpViewComponent
    {
        protected MPACorePHONEViewComponent()
        {
            LocalizationSourceName = MPACorePHONEConsts.LocalizationSourceName;
        }
    }
}
