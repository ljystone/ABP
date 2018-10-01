using Abp.Authorization;
using MPACorePHONE.Authorization.Roles;
using MPACorePHONE.Authorization.Users;

namespace MPACorePHONE.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
