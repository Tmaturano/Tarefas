using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Application.ViewModels;

namespace Tarefas.Application.Interfaces
{
    public interface ITarefaAppService : IDisposable
    {
        void Adicionar(TarefaViewModel tarefa);
        void Remover(TarefaViewModel tarefa);
        void Atualizar(TarefaViewModel tarefa);
        Task<IEnumerable<TarefaViewModel>> BuscarTarefasAtivas();
    }
}
