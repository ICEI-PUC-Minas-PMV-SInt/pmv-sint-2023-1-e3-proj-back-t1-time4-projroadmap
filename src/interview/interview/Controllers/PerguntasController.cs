using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using interview.Models;

namespace interview.Controllers
{
    public class PerguntasController : Controller
    {
        private readonly MyDbContext _context;

        public PerguntasController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Perguntas
        public async Task<IActionResult> Index()
        {
              return _context.Perguntas != null ? 
                          View(await _context.Perguntas.ToListAsync()) :
                          Problem("Entity set 'MyDbContext.Perguntas'  is null.");
        }

        // GET: Perguntas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Perguntas == null)
            {
                return NotFound();
            }

            var perguntas = await _context.Perguntas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (perguntas == null)
            {
                return NotFound();
            }

            return View(perguntas);
        }

        // GET: Perguntas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Perguntas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,idTema")] Perguntas perguntas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(perguntas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(perguntas);
        }

        // GET: Perguntas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Perguntas == null)
            {
                return NotFound();
            }

            var perguntas = await _context.Perguntas.FindAsync(id);
            if (perguntas == null)
            {
                return NotFound();
            }
            return View(perguntas);
        }

        // POST: Perguntas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,idTema")] Perguntas perguntas)
        {
            if (id != perguntas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(perguntas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerguntasExists(perguntas.Id))
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
            return View(perguntas);
        }

        // GET: Perguntas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Perguntas == null)
            {
                return NotFound();
            }

            var perguntas = await _context.Perguntas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (perguntas == null)
            {
                return NotFound();
            }

            return View(perguntas);
        }

        // POST: Perguntas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Perguntas == null)
            {
                return Problem("Entity set 'MyDbContext.Perguntas'  is null.");
            }
            var perguntas = await _context.Perguntas.FindAsync(id);
            if (perguntas != null)
            {
                _context.Perguntas.Remove(perguntas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerguntasExists(int id)
        {
          return (_context.Perguntas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
