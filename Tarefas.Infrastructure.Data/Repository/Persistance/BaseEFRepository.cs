using System;
using Tarefas.Domain.Interfaces.Repository.Persistance;

namespace Tarefas.Infrastructure.Data.Repository.Persistance
{
    public class BaseEFRepository<TEntity> : IBaseEFRepository<TEntity> where TEntity : class
    {
        //protected readonly IDbSet<TEntity> DbSet;
        //protected readonly IDbContext Context;
        //readonly DbContext recuperadorContext;

        public BaseEFRepository()
        {
            //Context = _contextManager.GetContext();
            //DbSet = Context.Set<TEntity>();
        }
        public void Adicionar(TEntity obj)
        {
            throw new NotImplementedException();
            // DbSet.Add(obj);
        }

        public void Atualizar(TEntity obj)
        {
            throw new NotImplementedException();

            //var entry = Context.Entry(obj);
            //DbSet.Attach(obj);
            //entry.State = EntityState.Modified;

        }

        public void Remover(TEntity obj)
        {
            throw new NotImplementedException();
            //DbSet.Remove(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();

            //Context.Dispose();
            //GC.SuppressFinalize(this);
        }
    }
}
