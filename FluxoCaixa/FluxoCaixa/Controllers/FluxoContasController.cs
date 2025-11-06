using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FluxoCaixa.Data;
using FluxoCaixa.Models;

namespace FluxoCaixa.Controllers
{
    public class FluxoContasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FluxoContasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FluxoContas
        public async Task<IActionResult> Index()
        {
            return View(await _context.FluxoConta.ToListAsync());
        }

        // GET: FluxoContas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fluxoConta = await _context.FluxoConta
                .FirstOrDefaultAsync(m => m.FluxoContaId == id);
            if (fluxoConta == null)
            {
                return NotFound();
            }

            return View(fluxoConta);
        }

        // GET: FluxoContas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FluxoContas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FluxoContaId,DataMovimentacao,ContaId,ContaFinanceiraId,UsuarioId")] FluxoConta fluxoConta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fluxoConta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fluxoConta);
        }

        // GET: FluxoContas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fluxoConta = await _context.FluxoConta.FindAsync(id);
            if (fluxoConta == null)
            {
                return NotFound();
            }
            return View(fluxoConta);
        }

        // POST: FluxoContas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FluxoContaId,DataMovimentacao,ContaId,ContaFinanceiraId,UsuarioId")] FluxoConta fluxoConta)
        {
            if (id != fluxoConta.FluxoContaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fluxoConta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FluxoContaExists(fluxoConta.FluxoContaId))
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
            return View(fluxoConta);
        }

        // GET: FluxoContas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fluxoConta = await _context.FluxoConta
                .FirstOrDefaultAsync(m => m.FluxoContaId == id);
            if (fluxoConta == null)
            {
                return NotFound();
            }

            return View(fluxoConta);
        }

        // POST: FluxoContas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fluxoConta = await _context.FluxoConta.FindAsync(id);
            if (fluxoConta != null)
            {
                _context.FluxoConta.Remove(fluxoConta);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FluxoContaExists(int id)
        {
            return _context.FluxoConta.Any(e => e.FluxoContaId == id);
        }
    }
}
