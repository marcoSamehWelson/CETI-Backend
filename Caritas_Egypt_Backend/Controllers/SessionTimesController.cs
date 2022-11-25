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
    public class SessionTimesController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public SessionTimesController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: SessionTimes
        public async Task<IActionResult> Index(string? name)
        {
            if (name != null)
            {

                return View(await _context.SessionTimes.Where(s => s.Name == name).ToListAsync());

            }
            else
            {
                return View(await _context.SessionTimes.ToListAsync());
            }
        }

        // GET: SessionTimes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessionTime = await _context.SessionTimes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sessionTime == null)
            {
                return NotFound();
            }

            return View(sessionTime);
        }

        // GET: SessionTimes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SessionTimes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] SessionTime sessionTime)
        {
            if (ModelState.IsValid)
            {
                sessionTime.Id = Guid.NewGuid();
                _context.Add(sessionTime);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sessionTime);
        }

        // GET: SessionTimes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessionTime = await _context.SessionTimes.FindAsync(id);
            if (sessionTime == null)
            {
                return NotFound();
            }
            return View(sessionTime);
        }

        // POST: SessionTimes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name")] SessionTime sessionTime)
        {
            if (id != sessionTime.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sessionTime);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SessionTimeExists(sessionTime.Id))
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
            return View(sessionTime);
        }

        // GET: SessionTimes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessionTime = await _context.SessionTimes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sessionTime == null)
            {
                return NotFound();
            }

            return View(sessionTime);
        }

        // POST: SessionTimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sessionTime = await _context.SessionTimes.FindAsync(id);
            _context.SessionTimes.Remove(sessionTime);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SessionTimeExists(Guid id)
        {
            return _context.SessionTimes.Any(e => e.Id == id);
        }
    }
}
