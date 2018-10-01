using System.Threading.Tasks;
using Abp.Application.Services;
using MPACorePHONE.Sessions.Dto;

namespace MPACorePHONE.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
