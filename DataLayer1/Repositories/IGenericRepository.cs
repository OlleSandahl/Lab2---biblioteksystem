using System.Collections.Generic;

namespace DataLayer1.Repositories
{
    public interface IGenericRepository<TEntity>
    {
        LibarysystemDBcontext LibarysystemDBcontext { get; }

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entity);
        TEntity Get(int id);
        TEntity Get2(int id);
        List<TEntity> GetAll();
        TEntity GetEntity(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entity);
    }
}