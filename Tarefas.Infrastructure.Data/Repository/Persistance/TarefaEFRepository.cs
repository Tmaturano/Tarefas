using Tarefas.Domain.Entities;
using Tarefas.Domain.Interfaces.Repository.Persistance;

namespace Tarefas.Infrastructure.Data.Repository.Persistance
{
    public class TarefaEFRepository : BaseEFRepository<Tarefa>, ITarefaEFRepository
    {
        //Passar o context para o base
        public TarefaEFRepository()
        {

        }
    }
}
