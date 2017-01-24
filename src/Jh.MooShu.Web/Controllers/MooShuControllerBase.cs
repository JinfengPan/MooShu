using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNet.Identity;
using Abp.IdentityFramework;

namespace Jh.MooShu.Web.Controllers
{
    public abstract class MooShuControllerBase: AbpController
    {
        protected MooShuControllerBase()
        {
            LocalizationSourceName = MooShuConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}