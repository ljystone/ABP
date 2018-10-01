using System.Threading.Tasks;
using MPACorePHONE.Configuration.Dto;

namespace MPACorePHONE.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
