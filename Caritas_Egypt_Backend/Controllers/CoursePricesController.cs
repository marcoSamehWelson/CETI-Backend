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
    public class CoursePricesController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public CoursePricesController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: CoursePrices
        public async Task<IActionResult> Index(string? name)
        {
            if (name != null)
            {

                return View(await _context.CoursePrices.Where(s => s.service.Name == name).ToListAsync());

            }
            else
            {
                var cETICaretasEgyptContext = _context.CoursePrices.Include(c => c.branch).Include(c => c.service).Include(c => c.studentNationality);
                return View(await cETICaretasEgyptContext.ToListAsync());
            }
        }


        // GET: CoursePrices/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursePrice = await _context.CoursePrices
                .Include(c => c.branch)
                .Include(c => c.service)
                .Include(c => c.studentNationality)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coursePrice == null)
            {
                return NotFound();
            }

            return View(coursePrice);
        }

        // GET: CoursePrices/Create
        public IActionResult Create()
        {
            ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name");
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Name");
            ViewData["StudentNationalityId"] = new SelectList(_context.StudentNationalities, "Id", "Name");
            return View();
        }

        // POST: CoursePrices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ServiceId,StudentNationalityId,BranchId,Price")] CoursePrice coursePrice)
        {
            if (ModelState.IsValid)
            {
                coursePrice.Id = Guid.NewGuid();
                _context.Add(coursePrice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name", coursePrice.BranchId);
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Name", coursePrice.ServiceId);
            ViewData["StudentNationalityId"] = new SelectList(_context.StudentNationalities, "Id", "Name", coursePrice.StudentNationalityId);
            return View(coursePrice);
        }

        // GET: CoursePrices/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursePrice = await _context.CoursePrices.FindAsync(id);
            if (coursePrice == null)
            {
                return NotFound();
            }
            ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name", coursePrice.BranchId);
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Name", coursePrice.ServiceId);
            ViewData["StudentNationalityId"] = new SelectList(_context.StudentNationalities, "Id", "Name", coursePrice.StudentNationalityId);
            return View(coursePrice);
        }

        // POST: CoursePrices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,ServiceId,StudentNationalityId,BranchId,Price")] CoursePrice coursePrice)
        {
            if (id != coursePrice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coursePrice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoursePriceExists(coursePrice.Id))
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
            ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Name", coursePrice.BranchId);
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Name", coursePrice.ServiceId);
            ViewData["StudentNationalityId"] = new SelectList(_context.StudentNationalities, "Id", "Name", coursePrice.StudentNationalityId);
            return View(coursePrice);
        }

        // GET: CoursePrices/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursePrice = await _context.CoursePrices
                .Include(c => c.branch)
                .Include(c => c.service)
                .Include(c => c.studentNationality)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coursePrice == null)
            {
                return NotFound();
            }

            return View(coursePrice);
        }

        // POST: CoursePrices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var coursePrice = await _context.CoursePrices.FindAsync(id);
            _context.CoursePrices.Remove(coursePrice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoursePriceExists(Guid id)
        {
            return _context.CoursePrices.Any(e => e.Id == id);
        }
    }
}
