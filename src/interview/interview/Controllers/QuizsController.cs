﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using interview.Models;
using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Identity;

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

        [HttpGet]
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
            var quizViewModel = new QuizViewModel { Tema = selectedTheme, Perguntas = questions, Respostas = respostas };

            return View("Quiz", quizViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> ScoreA(int[] RespostasSelecionadas)
        {
            int pontos =0;
            string userId = User.Identity.Name;
            foreach (var resposta in RespostasSelecionadas)
            {
                var respostaSelecionada = _context.Respostas?.FirstOrDefault(r => r.Id == resposta);
                if (respostaSelecionada.IsCorrect == Respostas.Correct.True)
                {
                    pontos++;
                }
            }

            var score = new Score
            {
                Pontos = pontos,
                IdUsuario = 1
            };

            if (ModelState.IsValid)
            {
                _context.Add(score);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(score);

    
        }

    }
    

}
