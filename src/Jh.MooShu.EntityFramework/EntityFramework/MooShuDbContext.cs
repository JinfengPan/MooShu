using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Microsoft.Extensions.Configuration;
using Jh.MooShu.Authorization.Roles;
using Jh.MooShu.Configuration;
using Jh.MooShu.MultiTenancy;
using Jh.MooShu.Users;
using Jh.MooShu.Web;

namespace Jh.MooShu.EntityFramework
{
    [DbConfigurationType(typeof(MooShuDbConfiguration))]
    public class MooShuDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        /* Default constructor is needed for EF command line tool. */
        public MooShuDbContext()
            : base(GetConnectionString())
        {

        }

        private static string GetConnectionString()
        {
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder()
                );

            return configuration.GetConnectionString(
                MooShuConsts.ConnectionStringName
                );
        }

        /* This constructor is used by ABP to pass connection string.
         * Notice that, actually you will not directly create an instance of MooShuDbContext since ABP automatically handles it.
         */
        public MooShuDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        /* This constructor is used in tests to pass a fake/mock connection. */
        public MooShuDbContext(DbConnection dbConnection)
            : base(dbConnection, true)
        {

        }

        public MooShuDbContext(DbConnection dbConnection, bool contextOwnsConnection)
            : base(dbConnection, contextOwnsConnection)
        {

        }
    }

    public class MooShuDbConfiguration : DbConfiguration
    {
        public MooShuDbConfiguration()
        {
            SetProviderServices(
                "System.Data.SqlClient",
                System.Data.Entity.SqlServer.SqlProviderServices.Instance
            );
        }
    }
}
