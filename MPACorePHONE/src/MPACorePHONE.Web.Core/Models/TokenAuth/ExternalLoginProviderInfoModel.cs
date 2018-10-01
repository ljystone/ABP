using Abp.AutoMapper;
using MPACorePHONE.Authentication.External;

namespace MPACorePHONE.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
