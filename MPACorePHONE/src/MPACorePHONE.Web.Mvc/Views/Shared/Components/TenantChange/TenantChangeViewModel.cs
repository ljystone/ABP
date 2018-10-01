using Abp.AutoMapper;
using MPACorePHONE.Sessions.Dto;

namespace MPACorePHONE.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
