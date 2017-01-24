using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Jh.MooShu.EntityFramework.Repositories
{
    public abstract class MooShuRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MooShuDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MooShuRepositoryBase(IDbContextProvider<MooShuDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MooShuRepositoryBase<TEntity> : MooShuRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MooShuRepositoryBase(IDbContextProvider<MooShuDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
