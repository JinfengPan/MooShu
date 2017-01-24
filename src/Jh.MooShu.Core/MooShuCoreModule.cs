using System.Reflection;
using Abp.Modules;
using Abp.Timing;
using Abp.Zero;
using Jh.MooShu.Localization;
using Abp.Zero.Configuration;
using Jh.MooShu.MultiTenancy;
using Jh.MooShu.Authorization.Roles;
using Jh.MooShu.Users;
using Jh.MooShu.Timing;

namespace Jh.MooShu
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class MooShuCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            MooShuLocalizationConfigurer.Configure(Configuration.Localization);

            //Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = true;

            //Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}