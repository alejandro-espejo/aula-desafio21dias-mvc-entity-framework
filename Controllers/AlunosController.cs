using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mvc_entity.Models;
using mvc_entity.Servicos;

namespace mvc_entity.Controllers
{
    [ApiController]
    public class AlunosController : ControllerBase //Controller
    {
        private readonly DbContexto _context;

        public AlunosController(DbContexto context)
        {
            _context = context;
        }

        // GET: Alunos
        [HttpGet]
        [Route("/alunos")]
        public async Task<IActionResult> Index()
        {
            //return View(await _context.Alunos.ToListAsync());
            return StatusCode(200, await _context.Alunos.ToListAsync());
        }

        // GET: alunos/5
        [HttpGet]
        [Route("/alunos/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await _context.Alunos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }
            return StatusCode(200, aluno);
            //return View(aluno);
        }

        // POST: /alunos
        //[ValidateAntiForgeryToken]
        [HttpPost]
        [Route("/alunos")]
        public async Task<IActionResult> Create([Bind("Id,Nome,Matricula,Notas")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aluno);
                await _context.SaveChangesAsync();
                return StatusCode(201, aluno);
                //return RedirectToAction(nameof(Index));
            }
            //return View(aluno);
            return StatusCode(201, aluno);
        }

        // PUT: alunos/5
        [HttpPut]
        [Route("/alunos/{id}")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Matricula,Notas")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    aluno.Id = id;
                    _context.Update(aluno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlunoExists(aluno.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));
                return StatusCode(200, aluno);
            }
            //return View(aluno);
            return StatusCode(200, aluno);
        }
        
        // DELETE: aluno/5
        [HttpDelete] // , ActionName("Delete")
        [Route("/alunos/{id}")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno != null)
            {
                _context.Alunos.Remove(aluno);
            }

            await _context.SaveChangesAsync();
            return StatusCode(204);
            //return RedirectToAction(nameof(Index));
        }

        private bool AlunoExists(int id)
        {
            return _context.Alunos.Any(e => e.Id == id);
        }
    }
}
