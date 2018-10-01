using System.Collections.Generic;
using MPACorePHONE.Roles.Dto;
using MPACorePHONE.Users.Dto;

namespace MPACorePHONE.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
