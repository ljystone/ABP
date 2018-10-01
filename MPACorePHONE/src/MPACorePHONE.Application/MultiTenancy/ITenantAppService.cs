using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MPACorePHONE.MultiTenancy.Dto;

namespace MPACorePHONE.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
