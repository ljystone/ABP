using System.Collections.Generic;
using MPACorePHONE.Roles.Dto;

namespace MPACorePHONE.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}