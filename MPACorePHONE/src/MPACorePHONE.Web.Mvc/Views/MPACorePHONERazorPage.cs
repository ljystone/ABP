using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace MPACorePHONE.Web.Views
{
    public abstract class MPACorePHONERazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MPACorePHONERazorPage()
        {
            LocalizationSourceName = MPACorePHONEConsts.LocalizationSourceName;
        }
    }
}
