using AutoMapper;
using Tarefas.Application.ViewModels;
using Tarefas.Domain.Entities;

namespace Tarefas.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<TarefaViewModel, Tarefa>()
                .ForMember(
                    m => m.DataCriacao, opt => opt.Ignore()
                )
                .ForMember(
                    m => m.DataAlteracao, opt => opt.Ignore()
                )
                .ForMember(
                    m => m.DataExclusao, opt => opt.Ignore()
                );
        }
    }
}
