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
    public class RespostasController : Controller
    {
        private readonly MyDbContext _context;

        public RespostasController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Respostas
        public async Task<IActionResult> Index()
        {
              return _context.Respostas != null ? 
                          View(await _context.Respostas.ToListAsync()) :
                          Problem("Entity set 'MyDbContext.Respostas'  is null.");
        }

        // GET: Respostas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Respostas == null)
            {
                return NotFound();
            }

            var respostas = await _context.Respostas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (respostas == null)
            {
                return NotFound();
            }

            return View(respostas);
        }

        // GET: Respostas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Respostas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdPergunta,Description,IsCorrect")] Respostas respostas)
        {
            // Fetch the list of Perguntas from the database
            //var perguntas = _context.Perguntas.ToList();

            //// Create a SelectList using the Perguntas list
            //var perguntasSelectList = new SelectList(perguntas, "IdPergunta", "Description");

            //// Pass the SelectList to the view
            //ViewBag.PerguntasSelectList = perguntasSelectList;

           
            if (ModelState.IsValid)
            {
                _context.Add(respostas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(respostas);
        }

        // GET: Respostas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Respostas == null)
            {
                return NotFound();
            }

            var respostas = await _context.Respostas.FindAsync(id);
            if (respostas == null)
            {
                return NotFound();
            }
            return View(respostas);
        }

        // POST: Respostas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdPergunta,Description,IsCorrect")] Respostas respostas)
        {
            if (id != respostas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(respostas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RespostasExists(respostas.Id))
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
            return View(respostas);
        }

        // GET: Respostas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Respostas == null)
            {
                return NotFound();
            }

            var respostas = await _context.Respostas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (respostas == null)
            {
                return NotFound();
            }

            return View(respostas);
        }

        // POST: Respostas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Respostas == null)
            {
                return Problem("Entity set 'MyDbContext.Respostas'  is null.");
            }
            var respostas = await _context.Respostas.FindAsync(id);
            if (respostas != null)
            {
                _context.Respostas.Remove(respostas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RespostasExists(int id)
        {
          return (_context.Respostas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
