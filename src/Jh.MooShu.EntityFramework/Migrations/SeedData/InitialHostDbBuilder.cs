using Jh.MooShu.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Jh.MooShu.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MooShuDbContext _context;

        public InitialHostDbBuilder(MooShuDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
