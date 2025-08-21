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
            if (!ModelState.IsValid)
            {
                tarefa.TarefaId = _proximoId++; // atribui o id da tarefa
                _tarefas.Add(tarefa); // adiciona a tarefa na lista
                return RedirectToAction(nameof(Index)); // redireciona para a ação Index
            }
            return View(tarefa);// se o modelo não for válido, retorna a view com os dados preenchidos
        }

    }
}
