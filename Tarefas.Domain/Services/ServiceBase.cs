using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Domain.Interfaces.Repository.Persistance;
using Tarefas.Domain.Interfaces.Repository.ReadOnly;
using Tarefas.Domain.Interfaces.Services;

namespace Tarefas.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IBaseDapperRepository<TEntity> _baseDapperRepositoty;
        private readonly IBaseEFRepository<TEntity> _baseEFRepository;

        public ServiceBase(IBaseDapperRepository<TEntity> repositoryDapper, IBaseEFRepository<TEntity> repositoryEF)
        {
            _baseDapperRepositoty = repositoryDapper;
            _baseEFRepository = repositoryEF;
        }
                
        public void Adicionar(TEntity obj)
        {
            _baseEFRepository.Adicionar(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _baseEFRepository.Atualizar(obj);
        }
        
        public void Remover(TEntity obj)
        {
            _baseEFRepository.Remover(obj);
        }

        public async Task<TEntity> BuscarPorId(Guid id)
        {
            return await _baseDapperRepositoty.BuscarPorId(id);
        }

        public async Task<IEnumerable<TEntity>> BuscarTodos()
        {
            return await _baseDapperRepositoty.BuscarTodos();
        }

        public void Dispose()
        {
            _baseDapperRepositoty.Dispose();
            _baseEFRepository.Dispose();
        }
    }
}
