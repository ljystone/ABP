using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MPACorePHONE.Configuration.Dto;

namespace MPACorePHONE.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MPACorePHONEAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
