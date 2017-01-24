using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using Jh.MooShu.Configuration;
using Jh.MooShu.EntityFramework;

namespace Jh.MooShu.Migrator
{
    [DependsOn(typeof(MooShuEntityFrameworkModule))]
    public class MooShuMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MooShuMigratorModule()
        {
            _appConfiguration = AppConfigurations.Get(
                typeof(MooShuMigratorModule).Assembly.GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Database.SetInitializer<MooShuDbContext>(null);

            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MooShuConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}