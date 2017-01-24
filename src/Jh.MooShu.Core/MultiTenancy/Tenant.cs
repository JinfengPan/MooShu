using Abp.MultiTenancy;
using Jh.MooShu.Users;

namespace Jh.MooShu.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}