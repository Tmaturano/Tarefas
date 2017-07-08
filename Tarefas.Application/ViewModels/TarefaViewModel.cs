using System;
using System.ComponentModel.DataAnnotations;


namespace Tarefas.Application.ViewModels
{
    public class TarefaViewModel
    {
        [Key]
        public Guid Id { get; private set; }

        [Required(ErrorMessage = "O Título é obrigatório")]
        [MinLength(2, ErrorMessage = "O tamanho mínimo do Título é {1}")]
        [MaxLength(50, ErrorMessage = "O tamanho máximo do Título é {1}")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
                
        [Display(Name = "Concluída?")]
        public bool Status { get; private set; }

        [Required(ErrorMessage = "A Descrição é obrigatória")]
        [MinLength(2, ErrorMessage = "O tamanho mínimo da Descrição é {1}")]
        [MaxLength(150, ErrorMessage = "O tamanho máximo da Descrição é {1}")]
        [Display(Name = "Descrição")]
        public string Descricao { get; private set; }        

        public TarefaViewModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
