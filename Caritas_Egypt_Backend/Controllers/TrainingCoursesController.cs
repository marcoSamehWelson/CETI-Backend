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
    public class TrainingCoursesController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public TrainingCoursesController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: TrainingCourses
        public async Task<IActionResult> Index()
        {
            var cETICaretasEgyptContext = _context.TrainingCoursess.Include(t => t.branch);
            return View(await cETICaretasEgyptContext.ToListAsync());
        }

        // GET: TrainingCourses/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingCourses = await _context.TrainingCoursess
                .Include(t => t.branch)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainingCourses == null)
            {
                return NotFound();
            }

            return View(trainingCourses);
        }

        // GET: TrainingCourses/Create
        public IActionResult Create()
        {
            ViewData["branchId"] = new SelectList(_context.Branches, "Id", "Name");
            return View();
        }

        // POST: TrainingCourses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tittle,Descreption,img,branchId,StartDate,EndDate")] TrainingCourses trainingCourses)
        {
            if (ModelState.IsValid)
            {
                trainingCourses.Id = Guid.NewGuid();
                _context.Add(trainingCourses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["branchId"] = new SelectList(_context.Branches, "Id", "Name", trainingCourses.branchId);
            return View(trainingCourses);
        }

        // GET: TrainingCourses/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingCourses = await _context.TrainingCoursess.FindAsync(id);
            if (trainingCourses == null)
            {
                return NotFound();
            }
            ViewData["branchId"] = new SelectList(_context.Branches, "Id", "Name", trainingCourses.branchId);
            return View(trainingCourses);
        }

        // POST: TrainingCourses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Tittle,Descreption,img,branchId,StartDate,EndDate")] TrainingCourses trainingCourses)
        {
            if (id != trainingCourses.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainingCourses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainingCoursesExists(trainingCourses.Id))
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
            ViewData["branchId"] = new SelectList(_context.Branches, "Id", "Name", trainingCourses.branchId);
            return View(trainingCourses);
        }

        // GET: TrainingCourses/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingCourses = await _context.TrainingCoursess
                .Include(t => t.branch)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainingCourses == null)
            {
                return NotFound();
            }

            return View(trainingCourses);
        }

        // POST: TrainingCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var trainingCourses = await _context.TrainingCoursess.FindAsync(id);
            _context.TrainingCoursess.Remove(trainingCourses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainingCoursesExists(Guid id)
        {
            return _context.TrainingCoursess.Any(e => e.Id == id);
        }
    }
}
