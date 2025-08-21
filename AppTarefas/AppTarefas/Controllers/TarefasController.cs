using AppTarefas.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppTarefas.Controllers
{
    public class TarefasController : Controller
    {
        // lista em memória(grava as insformações apenas quando a aplicaçaõ está rodando)
        private static List<Tarefa> _tarefas = new List<Tarefa>();
        private static int _proximoId = 1;
        public IActionResult Index()
        {
            return View(_tarefas);//envia a lista de tarefas para a view
        }

        // GET: Tarefas/Create
        // GET -> método para "pegar " a pagina e exibir
        public IActionResult Create()
        {
            return View();
        }
        // POST: Tarefas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]// porteger contra ataques

        public IActionResult Create(Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                tarefa.TarefaId = _proximoId++; // atribui o id da tarefa
                _tarefas.Add(tarefa); // adiciona a tarefa na lista
                return RedirectToAction(nameof(Index)); // redireciona para a ação Index
            }
            return View(tarefa);// se o modelo não for válido, retorna a view com os dados preenchidos
        }
        public IActionResult Edit(int id)
        {
            var tarefa = _tarefas.FirstOrDefault(t => t.TarefaId == id);
            return View(tarefa);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Tarefa tarefaAtualizada)
        {
            var tarefa = _tarefas.FirstOrDefault(t => t.TarefaId == id);

            tarefa.Titulo = tarefaAtualizada.Titulo;
            tarefa.Descricao = tarefaAtualizada.Descricao;
            tarefa.Concluida = tarefaAtualizada.Concluida;

            return RedirectToAction("Index");



        }
        public IActionResult Details(int id)
        {
            var tarefa = _tarefas.FirstOrDefault(t => t.TarefaId == id);
            return View(tarefa);




        }
        public IActionResult Delete(int id)
        {
            var tarefa = _tarefas.FirstOrDefault(t => t.TarefaId == id);
            return View(tarefa);




        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public IActionResult DeleteConfirmed(int id)
        {
            var tarefa = _tarefas.FirstOrDefault(t => t.TarefaId == id);
            if (tarefa != null)
            {
                _tarefas.Remove(tarefa); // remove a tarefa da lista
            }
            return RedirectToAction(nameof(Index)); // redireciona para a ação Index
        }

    }

}
