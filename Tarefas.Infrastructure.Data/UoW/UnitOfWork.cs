using System;
using System.Collections.Generic;
using System.Text;
using Tarefas.Infrastructure.Data.Interfaces;

namespace Tarefas.Infrastructure.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
