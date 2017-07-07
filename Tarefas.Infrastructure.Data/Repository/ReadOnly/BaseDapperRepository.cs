using System;
using Tarefas.Domain.Interfaces.Repository.ReadOnly;
using Tarefas.Infrastructure.Data.Context;

namespace Tarefas.Infrastructure.Data.Repository.ReadOnly
{
    public class BaseDapperRepository : IBaseDapperRepository
    {
        protected readonly TarefasDapperContext tarefasContext;

        public BaseDapperRepository(TarefasDapperContext tarefasDapperContext)
        {
            tarefasContext = tarefasDapperContext;
        }
        
        public void Dispose()
        {
            tarefasContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
