using Abp.MultiTenancy;
using MPACorePHONE.Authorization.Users;

namespace MPACorePHONE.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
