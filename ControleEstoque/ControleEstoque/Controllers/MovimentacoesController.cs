using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleEstoque.Data;
using ControleEstoque.Models;
using System.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.AspNetCore.Identity;

namespace ControleEstoque.Controllers
{
    [Authorize]
    public class MovimentacoesController : Controller
    {// Injeção de dependencia
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;

        // Alterar as dependencias no método construtor
        public MovimentacoesController(ApplicationDbContext context, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
        }

        // GET: Movimentacoes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Movimentacao.Include(m => m.Produto).Include(m => m.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Movimentacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimentacao = await _context.Movimentacao
                .Include(m => m.Produto)
                .Include(m => m.Usuario)
                .FirstOrDefaultAsync(m => m.MovimentacaoId == id);
            if (movimentacao == null)
            {
                return NotFound();
            }

            return View(movimentacao);
        }

        // GET: Movimentacoes/Create
        public IActionResult Create()
        {
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "Nome");
            ViewData["UsuarioId"] = new SelectList(_context.Users, "Id", "Email");
            return View();
        }

        // POST: Movimentacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovimentacaoId,ProdutoId,Quantidade,Tipo,DataMovimentacao,UsuarioId,Observacao")] Movimentacao movimentacao)
        {
            if (ModelState.IsValid)
            {
                movimentacao.DataMovimentacao = DateTime.Now; // data atual
                movimentacao.UsuarioId = _signInManager.UserManager.GetUserId(User) // usuario logado

                // localizar um registro por id
                var produto = _context.Produto.FirstOrDefault(produto => produto.ProdutoId == movimentacao.ProdutoId);

                if (movimentacao.Tipo == "Entrada")
                {
                    produto.EstoqueAtual += movimentacao.Quantidade;
                }
                else
                {
                    // Antes de subtrair do estoque, é preciso verificar se o estoque atual é igual ou maior que a quantidade
                    if (produto.EstoqueAtual >= movimentacao.Quantidade)
                    {
                        produto.EstoqueAtual -= movimentacao.Quantidade;
                    }
                    else
                    {
                        ViewData["Alerta"] = "Estoque atual do produto" + produto.Nome + "(" + produto.EstoqueAtual + ") é menor que a quantidade da movimentação";
                        ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "Nome", movimentacao.ProdutoId);
                        ViewData["UsuarioId"] = new SelectList(_context.Users, "Id", "Email", movimentacao.UsuarioId);
                        return View(movimentacao);
                    }

                }
                _context.Add(movimentacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "Nome", movimentacao.ProdutoId);
            ViewData["UsuarioId"] = new SelectList(_context.Users, "Id", "Email", movimentacao.UsuarioId);
            return View(movimentacao);
        }


        // GET: Movimentacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimentacao = await _context.Movimentacao.FindAsync(id);
            if (movimentacao == null)
            {
                return NotFound();
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "Marca", movimentacao.ProdutoId);
            ViewData["UsuarioId"] = new SelectList(_context.Users, "Id", "Email", movimentacao.UsuarioId);
            return View(movimentacao);
        }

        // POST: Movimentacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovimentacaoId,ProdutoId,Quantidade,Tipo,DataMovimentacao,UsuarioId,Observacao")] Movimentacao movimentacao)
        {
            if (id != movimentacao.MovimentacaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movimentacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovimentacaoExists(movimentacao.MovimentacaoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "ProdutoId", "Marca", movimentacao.ProdutoId);
            ViewData["UsuarioId"] = new SelectList(_context.Users, "Id", "Email", movimentacao.UsuarioId);
            return View(movimentacao);
        }

        // GET: Movimentacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimentacao = await _context.Movimentacao
                .Include(m => m.Produto)
                .Include(m => m.Usuario)
                .FirstOrDefaultAsync(m => m.MovimentacaoId == id);
            if (movimentacao == null)
            {
                return NotFound();
            }

            return View(movimentacao);
        }

        // POST: Movimentacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movimentacao = await _context.Movimentacao.FindAsync(id);
            if (movimentacao != null)
            {
                //  verificar o tipo de movimentação
                // se for entrada-> retirar do estoque
                // senao -> devolver ao estoque

                var produto = _context.Produto.FirstOrDefault(produto => produto.ProdutoId == movimentacao.ProdutoId);
                if (movimentacao.Tipo == "Entrada")
                {
                    produto.EstoqueAtual -= movimentacao.Quantidade;
                }
                else
                {
                    produto.EstoqueAtual += movimentacao.Quantidade;
                }
                _context.Movimentacao.Remove(movimentacao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovimentacaoExists(int id)
        {
            return _context.Movimentacao.Any(e => e.MovimentacaoId == id);
        }
    }
}
