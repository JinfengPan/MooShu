using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jh.MooShu.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MooShuControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}