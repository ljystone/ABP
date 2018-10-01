using System.Collections.Generic;
using MPACorePHONE.Roles.Dto;

namespace MPACorePHONE.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
