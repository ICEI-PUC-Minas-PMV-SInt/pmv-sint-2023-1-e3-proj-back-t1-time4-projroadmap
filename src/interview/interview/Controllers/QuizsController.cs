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
    public class QuizsController : Controller
    {
        private readonly MyDbContext _context;

        public QuizsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: quizs
        public async Task<IActionResult> Index()
        {
            return _context.Tema != null ?
                        View(await _context.Tema.ToListAsync()) :
                        Problem("Entity set 'MyDbContext.'  is null.");
        }

        public IActionResult SelectTheme(int id)
        {
            // Get the selected theme based on the ID
            var selectedTheme = _context.Tema?.FirstOrDefault(t => t.Id == id);

            if (selectedTheme == null)
            {
                return NotFound();
            }

            // Get the questions related to the selected theme
            var questions = _context.Perguntas?.Where(p => p.idTema == selectedTheme.Id).ToList();

            var respostas = new List<Respostas>();

            List<int> IdsPerguntas = new List<int>();


            foreach (var question in questions)
            {
                IdsPerguntas.Add(question.Id);
            }

            foreach (var idPergunta in IdsPerguntas)
            {
                var resposta = _context.Respostas?.Where(r => r.IdPergunta == idPergunta).ToList();
                respostas.AddRange(resposta);
            }

            // Create a QuizViewModel and populate it with the selected theme and questions
            var quizViewModel = new QuizViewModel { Tema = selectedTheme, Perguntas = questions, Respostas = respostas};

            return View("Quiz", quizViewModel);
        }


    }
}
