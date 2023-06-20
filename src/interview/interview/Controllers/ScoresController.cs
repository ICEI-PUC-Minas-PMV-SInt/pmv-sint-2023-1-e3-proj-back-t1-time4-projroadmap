using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using interview.Models;
using System.Security.Claims;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore.Metadata;

namespace interview.Controllers
{
    public class ScoresController : Controller
    {
        private readonly MyDbContext _context;
        private readonly IHttpContextAccessor _accessor;

        public ScoresController(MyDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        // GET: Scores
        public async Task<IActionResult> Index()
        {
            int UserId = int.Parse(_accessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
            var scoreUser = _context.Score.Where(s => s.IdUsuario == UserId);

            return _context.Score != null ?
                          View(await scoreUser.ToListAsync()) :
                          Problem("Entity set 'MyDbContext.Tema'  is null.");
        }


        // GET: Scores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Score == null)
            {
                return NotFound();
            }

            var score = await _context.Score
                .FirstOrDefaultAsync(m => m.Id == id);
            if (score == null)
            {
                return NotFound();
            }

            return View(score);
        }

        // GET: Scores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Scores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Pontos,IdUsuario")] Score score)
        {
            if (ModelState.IsValid)
            {
                _context.Add(score);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(score);
        }

        // GET: Scores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Score == null)
            {
                return NotFound();
            }

            var score = await _context.Score.FindAsync(id);
            if (score == null)
            {
                return NotFound();
            }
            return View(score);
        }

        // POST: Scores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Pontos,IdUsuario")] Score score)
        {
            if (id != score.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(score);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScoreExists(score.Id))
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
            return View(score);
        }

        // GET: Scores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Score == null)
            {
                return NotFound();
            }

            var score = await _context.Score
                .FirstOrDefaultAsync(m => m.Id == id);
            if (score == null)
            {
                return NotFound();
            }

            return View(score);
        }

        // POST: Scores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Score == null)
            {
                return Problem("Entity set 'MyDbContext.Score'  is null.");
            }
            var score = await _context.Score.FindAsync(id);
            if (score != null)
            {
                _context.Score.Remove(score);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScoreExists(int id)
        {
          return (_context.Score?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
