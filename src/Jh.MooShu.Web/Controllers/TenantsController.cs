using Abp.AspNetCore.Mvc.Authorization;
using Jh.MooShu.Authorization;
using Jh.MooShu.MultiTenancy;
using Microsoft.AspNetCore.Mvc;

namespace Jh.MooShu.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : MooShuControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}