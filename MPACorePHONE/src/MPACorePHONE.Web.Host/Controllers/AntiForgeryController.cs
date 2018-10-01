using Microsoft.AspNetCore.Antiforgery;
using MPACorePHONE.Controllers;

namespace MPACorePHONE.Web.Host.Controllers
{
    public class AntiForgeryController : MPACorePHONEControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
