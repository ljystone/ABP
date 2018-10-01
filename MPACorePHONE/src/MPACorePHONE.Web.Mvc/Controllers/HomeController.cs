using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MPACorePHONE.Controllers;

namespace MPACorePHONE.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MPACorePHONEControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
