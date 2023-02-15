using Microsoft.EntityFrameworkCore;
using System;
using  Tryitter.Domain.Interfaces.Repository;
using  Tryitter.Infra.Context;

namespace  Tryitter.Infra.Repository
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class
    {
        protected readonly TryitterContext Db;
        protected readonly DbSet<T> DbSet;

        public EntityBaseRepository(TryitterContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        public virtual void Add(T obj)
        {
            DbSet.Add(obj);
        }

        public virtual void Update(T obj)
        {
            DbSet.Update(obj);
        }

        public virtual void Remove(T obj)
        {
            DbSet.Remove(obj);
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}