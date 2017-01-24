using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Jh.MooShu.Authorization;
using Jh.MooShu.Users;
using Microsoft.AspNetCore.Mvc;

namespace Jh.MooShu.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : MooShuControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }
    }
}