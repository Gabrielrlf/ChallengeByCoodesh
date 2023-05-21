using ChallengeCoodesh_BACK.Domain.Entities;
using ChallengeCoodesh_BACK.Domain.Interfaces;
using ChallengeCoodesh_BACK.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCoodesh_BACK.Infra.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly EntitiesDbContext _entitiesDbContext;

        public Repository(EntitiesDbContext entitiesDbContext)
        {
            _entitiesDbContext = entitiesDbContext;
        }

        public async Task Commit()
        {
            await _entitiesDbContext.SaveChangesAsync();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            var query = _entitiesDbContext.Set<TEntity>();

            if (query.Any())
                return query.ToList();

            return new List<TEntity>();
        }

        public virtual void Save(TEntity entity)
        {
            _entitiesDbContext.Set<TEntity>().Add(entity);
            _entitiesDbContext.SaveChangesAsync();
        }
    }
}
