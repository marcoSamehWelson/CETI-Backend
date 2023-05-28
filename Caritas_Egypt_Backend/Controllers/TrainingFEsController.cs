using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Caritas_Egypt_Backend.Models;

namespace Caritas_Egypt_Backend.Controllers
{
    public class TrainingFEsController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public TrainingFEsController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: TrainingFEs
        public async Task<IActionResult> Index()
        {
            return View(await _context.TrainingFEs.ToListAsync());
        }

        // GET: TrainingFEs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingFE = await _context.TrainingFEs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainingFE == null)
            {
                return NotFound();
            }

            return View(trainingFE);
        }

        // GET: TrainingFEs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TrainingFEs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tittle,Descreption,img")] TrainingFE trainingFE)
        {
            if (ModelState.IsValid)
            {
                trainingFE.Id = Guid.NewGuid();
                _context.Add(trainingFE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trainingFE);
        }

        // GET: TrainingFEs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingFE = await _context.TrainingFEs.FindAsync(id);
            if (trainingFE == null)
            {
                return NotFound();
            }
            return View(trainingFE);
        }

        // POST: TrainingFEs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Tittle,Descreption,img")] TrainingFE trainingFE)
        {
            if (id != trainingFE.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainingFE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainingFEExists(trainingFE.Id))
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
            return View(trainingFE);
        }

        // GET: TrainingFEs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingFE = await _context.TrainingFEs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainingFE == null)
            {
                return NotFound();
            }

            return View(trainingFE);
        }

        // POST: TrainingFEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var trainingFE = await _context.TrainingFEs.FindAsync(id);
            _context.TrainingFEs.Remove(trainingFE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainingFEExists(Guid id)
        {
            return _context.TrainingFEs.Any(e => e.Id == id);
        }
    }
}
