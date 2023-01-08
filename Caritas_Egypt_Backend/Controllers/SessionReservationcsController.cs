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
    public class SessionReservationcsController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public SessionReservationcsController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: SessionReservationcs
        public async Task<IActionResult> Index(string? studentname)
        {
            if (studentname != null)
            {

                return View(await _context.SessionReservation.Include(s => s.coursePrice).Include(s => s.trainer).Include(s => s.student).Where(s => s.student.Name == studentname).ToListAsync());

            }
            else
            {
                var cETICaretasEgyptContext = _context.SessionReservation.Include(s => s.coursePrice).Include(s => s.trainer).Include(s => s.student);
                return View(await cETICaretasEgyptContext.ToListAsync());
            }
        }

        // GET: SessionReservationcs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessionReservationcs = await _context.SessionReservation
                .Include(s => s.coursePrice)
                .Include(s => s.trainer)
                .Include(s => s.student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sessionReservationcs == null)
            {
                return NotFound();
            }

            return View(sessionReservationcs);
        }

        // GET: SessionReservationcs/Create
        public IActionResult Create()
        {
            ViewData["coursePriceId"] = new SelectList(_context.CoursePrices, "Id", "Name");
            ViewData["TrainerId"] = new SelectList(_context.Trainers, "Id", "FirstName");
            ViewData["StudentId"] = new SelectList(_context.Students, "ID", "Name");
            return View();
        }

        // POST: SessionReservationcs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,coursePriceId,StudentId,TrainerId,SessionDateTime")] SessionReservations sessionReservationcs)
        {
            if (ModelState.IsValid)
            {
                sessionReservationcs.Id = Guid.NewGuid();
                _context.Add(sessionReservationcs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["coursePriceId"] = new SelectList(_context.CoursePrices, "Id", "Name", sessionReservationcs.coursePriceId);
            ViewData["TrainerId"] = new SelectList(_context.Trainers, "Id", "FirstName", sessionReservationcs.TrainerId);
            ViewData["StudentId"] = new SelectList(_context.Students, "ID", "Name", sessionReservationcs.StudentId);

            return View(sessionReservationcs);
        }

        // GET: SessionReservationcs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessionReservationcs = await _context.SessionReservation.FindAsync(id);
            if (sessionReservationcs == null)
            {
                return NotFound();
            }
            ViewData["coursePriceId"] = new SelectList(_context.CoursePrices, "Id", "Name", sessionReservationcs.coursePriceId);
            ViewData["TrainerId"] = new SelectList(_context.Trainers, "Id", "FirstName", sessionReservationcs.TrainerId);
            ViewData["StudentId"] = new SelectList(_context.Students, "ID", "Name", sessionReservationcs.StudentId);

            return View(sessionReservationcs);
        }

        // POST: SessionReservationcs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,coursePriceId,StudentId,TrainerId,SessionDateTime")] SessionReservations sessionReservationcs)
        {
            if (id != sessionReservationcs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sessionReservationcs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SessionReservationcsExists(sessionReservationcs.Id))
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
            ViewData["coursePriceId"] = new SelectList(_context.CoursePrices, "Id", "Name", sessionReservationcs.coursePriceId);
            ViewData["TrainerId"] = new SelectList(_context.Trainers, "Id", "FirstName", sessionReservationcs.TrainerId);
            ViewData["StudentId"] = new SelectList(_context.Students, "ID", "Name", sessionReservationcs.StudentId);

            return View(sessionReservationcs);
        }

        // GET: SessionReservationcs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessionReservationcs = await _context.SessionReservation
                .Include(s => s.coursePrice)
                .Include(s => s.trainer)
                .Include(s => s.student)

                .FirstOrDefaultAsync(m => m.Id == id);
            if (sessionReservationcs == null)
            {
                return NotFound();
            }

            return View(sessionReservationcs);
        }

        // POST: SessionReservationcs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sessionReservationcs = await _context.SessionReservation.FindAsync(id);
            _context.SessionReservation.Remove(sessionReservationcs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SessionReservationcsExists(Guid id)
        {
            return _context.SessionReservation.Any(e => e.Id == id);
        }
    }
}
