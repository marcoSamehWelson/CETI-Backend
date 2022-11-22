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
    public class StudentParentsController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public StudentParentsController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: StudentParents
        public async Task<IActionResult> Index(string? name)
        {
            if (name != null)
            {

                return View(await _context.StudentParents.Where(s => s.FirstName == name || s.SecondName == name).ToListAsync());

            }
            else
            {
                return View(await _context.StudentParents.ToListAsync());
            }
        }

        // GET: StudentParents/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentParent = await _context.StudentParents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentParent == null)
            {
                return NotFound();
            }

            return View(studentParent);
        }
       
        // GET: StudentParents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentParents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,SecondName,LastName,PhoneNumber,LandPhoneNumber,EducationQualification,JopTitle,Email,MotherFirstName,MotherSecondName,MotherLastName,MotherPhoneNumber,MotherEducationQualification,MotherJopTitle")] StudentParent studentParent)
        {
            if (ModelState.IsValid)
            {
                studentParent.Id = Guid.NewGuid();
                _context.Add(studentParent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentParent);
        }

        // GET: StudentParents/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentParent = await _context.StudentParents.FindAsync(id);
            if (studentParent == null)
            {
                return NotFound();
            }
            return View(studentParent);
        }

        // POST: StudentParents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,SecondName,LastName,PhoneNumber,LandPhoneNumber,EducationQualification,JopTitle,Email,MotherFirstName,MotherSecondName,MotherLastName,MotherPhoneNumber,MotherEducationQualification,MotherJopTitle")] StudentParent studentParent)
        {
            if (id != studentParent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentParent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentParentExists(studentParent.Id))
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
            return View(studentParent);
        }

        // GET: StudentParents/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentParent = await _context.StudentParents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentParent == null)
            {
                return NotFound();
            }

            return View(studentParent);
        }

        // POST: StudentParents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var studentParent = await _context.StudentParents.FindAsync(id);
            _context.StudentParents.Remove(studentParent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentParentExists(Guid id)
        {
            return _context.StudentParents.Any(e => e.Id == id);
        }
    }
}
