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
    public class StudentNationalitiesController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public StudentNationalitiesController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: StudentNationalities
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentNationalities.ToListAsync());
        }

        // GET: StudentNationalities/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentNationality = await _context.StudentNationalities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentNationality == null)
            {
                return NotFound();
            }

            return View(studentNationality);
        }

        // GET: StudentNationalities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentNationalities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] StudentNationality studentNationality)
        {
            if (ModelState.IsValid)
            {
                studentNationality.Id = Guid.NewGuid();
                _context.Add(studentNationality);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentNationality);
        }

        // GET: StudentNationalities/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentNationality = await _context.StudentNationalities.FindAsync(id);
            if (studentNationality == null)
            {
                return NotFound();
            }
            return View(studentNationality);
        }

        // POST: StudentNationalities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name")] StudentNationality studentNationality)
        {
            if (id != studentNationality.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentNationality);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentNationalityExists(studentNationality.Id))
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
            return View(studentNationality);
        }

        // GET: StudentNationalities/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentNationality = await _context.StudentNationalities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentNationality == null)
            {
                return NotFound();
            }

            return View(studentNationality);
        }

        // POST: StudentNationalities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var studentNationality = await _context.StudentNationalities.FindAsync(id);
            _context.StudentNationalities.Remove(studentNationality);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentNationalityExists(Guid id)
        {
            return _context.StudentNationalities.Any(e => e.Id == id);
        }
    }
}
