using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer1.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public GenericRepository(LibarysystemDBcontext libarysystemDBcontext)
        {
            LibarysystemDBcontext = libarysystemDBcontext;
        }

        public LibarysystemDBcontext LibarysystemDBcontext { get; }

        public List<TEntity> GetAll()
        {

            return LibarysystemDBcontext.Set<TEntity>().ToList();
        }
        public TEntity GetEntity(TEntity entity)
        {
            return LibarysystemDBcontext.Set<TEntity>().Find(entity);
        }
        public TEntity Get(int id)
        {
            return LibarysystemDBcontext.Set<TEntity>().Find(id);
        }
        public TEntity Get2(int id)
        {
            return null; 
        }
        public void Add(TEntity entity)
        {
            LibarysystemDBcontext.Set<TEntity>().Add(entity);
        }
        public void Remove(TEntity entity)
        {
            LibarysystemDBcontext.Set<TEntity>().Remove(entity);
        }
        public void AddRange(IEnumerable<TEntity> entity)
        {
            LibarysystemDBcontext.Set<TEntity>().AddRange(entity);
        }
        public void RemoveRange(IEnumerable<TEntity> entity)
        {
            LibarysystemDBcontext.Set<TEntity>().RemoveRange(entity);
        }
    }
}
