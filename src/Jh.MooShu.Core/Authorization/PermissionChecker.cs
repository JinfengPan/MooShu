using Abp.Authorization;
using Jh.MooShu.Authorization.Roles;
using Jh.MooShu.MultiTenancy;
using Jh.MooShu.Users;

namespace Jh.MooShu.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
