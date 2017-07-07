using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Domain.Entities;
using Tarefas.Domain.Interfaces.Repository.Persistance;
using Tarefas.Domain.Interfaces.Repository.ReadOnly;
using Tarefas.Domain.Interfaces.Services;

namespace Tarefas.Domain.Services
{
    public class TarefaService : ServiceBase<Tarefa>, ITarefaService
    {        
        private readonly ITarefaDapperRepository _tarefaDapperRepository;

        public TarefaService(ITarefaDapperRepository tarefaDapperRepository, ITarefaEFRepository tarefaEFRepository)
            : base(tarefaDapperRepository, tarefaEFRepository)
        {
            _tarefaDapperRepository = tarefaDapperRepository;     
        }

        public async Task<IEnumerable<Tarefa>> BuscarTarefasAtivas()
        {
            return  await _tarefaDapperRepository.BuscarTarefasAtivas();
        }
    }
}
