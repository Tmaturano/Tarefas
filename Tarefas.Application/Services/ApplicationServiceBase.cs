using System;
using System.Collections.Generic;
using System.Text;
using Tarefas.Infrastructure.Data.Interfaces;

namespace Tarefas.Application.Services
{
    public abstract class ApplicationServiceBase
    {            
        private readonly IUnitOfWork _unitOfWork;

        public ApplicationServiceBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void BeginTransaction()
        {
            _unitOfWork.BeginTransaction();
        }

        public void Commit()
        {
            _unitOfWork.Commit();
        }
    }
}
