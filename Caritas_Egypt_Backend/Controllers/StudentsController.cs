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
    public class StudentsController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public StudentsController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index(string? name)
        {
            if (name != null) {

                return View(await _context.Students.Where(s => s.Name==name).Include(s => s.TypeOfDisability).ToListAsync());

            } else {
            return View(await _context.Students.Include(s => s.TypeOfDisability).ToListAsync());
            }
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.TypeOfDisability)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        public async Task<IActionResult> Search(int? id,string? name)
        {
            
            if (id == null)
            {
                return NotFound();
            }
           
                var student =  _context.Students.Where(s => s.Name == name)
                    .Include(s => s.TypeOfDisability);
            


            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        // GET: Students/Create
        public IActionResult Create()
        {
            ViewData["TypeOfDisabilityId"] = new SelectList(_context.TypeOfDisabilitys, "Id", "Name");
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TypeOfDisabilityId"] = new SelectList(_context.TypeOfDisabilitys, "Id", "Name", student.TypeOfDisabilityId);
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            ViewData["TypeOfDisabilityId"] = new SelectList(_context.TypeOfDisabilitys, "Id", "Name", student.TypeOfDisabilityId);
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            if (id != student.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.ID))
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
            ViewData["TypeOfDisabilityId"] = new SelectList(_context.TypeOfDisabilitys, "Id", "Name", student.TypeOfDisabilityId);
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.TypeOfDisability)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Students.FindAsync(id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.ID == id);
        }
    }
}
