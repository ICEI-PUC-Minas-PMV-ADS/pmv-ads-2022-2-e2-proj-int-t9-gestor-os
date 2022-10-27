using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestorOS.Models;

namespace GestorOS.Controllers
{
    public class OrdensDeServicosController : Controller
    {
        private readonly BancodeDados _context;

        public OrdensDeServicosController(BancodeDados context)
        {
            _context = context;
        }

        // GET: OrdensDeServicos
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrdensDeServicos.ToListAsync());
        }

        // GET: OrdensDeServicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordensDeServicos = await _context.OrdensDeServicos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordensDeServicos == null)
            {
                return NotFound();
            }

            return View(ordensDeServicos);
        }

        // GET: OrdensDeServicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrdensDeServicos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao,Tipo,Data,Feito")] OrdensDeServicos ordensDeServicos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordensDeServicos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ordensDeServicos);
        }

        // GET: OrdensDeServicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordensDeServicos = await _context.OrdensDeServicos.FindAsync(id);
            if (ordensDeServicos == null)
            {
                return NotFound();
            }
            return View(ordensDeServicos);
        }

        // POST: OrdensDeServicos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao,Tipo,Data,Feito")] OrdensDeServicos ordensDeServicos)
        {
            if (id != ordensDeServicos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordensDeServicos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdensDeServicosExists(ordensDeServicos.Id))
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
            return View(ordensDeServicos);
        }

        // GET: OrdensDeServicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordensDeServicos = await _context.OrdensDeServicos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordensDeServicos == null)
            {
                return NotFound();
            }

            return View(ordensDeServicos);
        }

        // POST: OrdensDeServicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordensDeServicos = await _context.OrdensDeServicos.FindAsync(id);
            _context.OrdensDeServicos.Remove(ordensDeServicos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdensDeServicosExists(int id)
        {
            return _context.OrdensDeServicos.Any(e => e.Id == id);
        }
    }
}
