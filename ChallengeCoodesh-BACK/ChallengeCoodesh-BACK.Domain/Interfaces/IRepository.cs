using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCoodesh_BACK.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Save(TEntity entity);
        IEnumerable<TEntity> GetAll();
        Task Commit();

    }
}
