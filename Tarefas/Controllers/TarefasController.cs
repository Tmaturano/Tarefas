using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Application.Interfaces;
using Tarefas.Application.ViewModels;

namespace Tarefas.UI.MVC.Controllers
{
    public class TarefasController : Controller
    {
        private readonly ITarefaAppService _tarefaAppService;

        public TarefasController(ITarefaAppService tarefaAppService)
        {
            _tarefaAppService = tarefaAppService;
        }

        [Route("")]
        [Route("minhas-tarefas")]
        public async Task<IActionResult> Index()
        {
            return View(await _tarefaAppService.BuscarTarefasAtivas());
        }

        [Route("detalhes-da-tarefa/{id:guid}")]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
                return NotFound();

            var tarefa = await _tarefaAppService.BuscarPorId(id.Value);
            if (tarefa == null)
                return NotFound();

            return View(tarefa);
        }

        [Route("nova-tarefa")]
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("nova-tarefa")]
        public IActionResult Create(TarefaViewModel tarefaViewModel)
        {
            if (!ModelState.IsValid)
                return View(tarefaViewModel);

            _tarefaAppService.Adicionar(tarefaViewModel);
            //TODO: Colocar o retorno do adicionar em uma viewbag e mostrar para o usuário se deu sucesso ou fracasso.

            return RedirectToAction("Index");
        }

        [Route("editar-tarefa/{id:guid}")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
                return NotFound();

            var tarefa = await _tarefaAppService.BuscarPorId(id.Value);
            if (tarefa == null)
                return NotFound();
                        
            return View(tarefa);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("editar-tarefa")]
        public IActionResult Edit(TarefaViewModel tarefaViewModel)
        {
            if (!ModelState.IsValid)
                return View(tarefaViewModel);

            _tarefaAppService.Atualizar(tarefaViewModel);
            //TODO: Colocar o retorno do adicionar em uma viewbag e mostrar para o usuário se deu sucesso ou fracasso.

            return RedirectToAction("Index");
        }

        [Route("apagar-tarefa/{id:guid}")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
                return NotFound();

            var tarefa = await _tarefaAppService.BuscarPorId(id.Value);
            if (tarefa == null)
                return NotFound();
            
            return View(tarefa);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("apagar-tarefa")]
        public async Task<IActionResult> DeleteConfirmed(Guid? id)
        {
            if (id == null)
                return NotFound();

            var tarefa = await _tarefaAppService.BuscarPorId(id.Value);
            if (tarefa == null)
                return NotFound();

            _tarefaAppService.Remover(tarefa);
            //TODO: Colocar o retorno do adicionar em uma viewbag e mostrar para o usuário se deu sucesso ou fracasso.

            return RedirectToAction("Index");
        }
    }
}