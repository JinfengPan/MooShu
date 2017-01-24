using Microsoft.AspNetCore.Mvc;

namespace Jh.MooShu.Web.Controllers
{
    public class AboutController : MooShuControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}