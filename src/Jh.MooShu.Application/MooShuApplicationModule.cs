using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Jh.MooShu.Authorization;

namespace Jh.MooShu
{
    [DependsOn(
        typeof(MooShuCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MooShuApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MooShuAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}