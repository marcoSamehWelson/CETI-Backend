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
    public class ActivitiesAndEventsFEsController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public ActivitiesAndEventsFEsController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: ActivitiesAndEventsFEs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ActivitiesAndEventsFEs.ToListAsync());
        }

        // GET: ActivitiesAndEventsFEs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activitiesAndEventsFE = await _context.ActivitiesAndEventsFEs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activitiesAndEventsFE == null)
            {
                return NotFound();
            }

            return View(activitiesAndEventsFE);
        }

        // GET: ActivitiesAndEventsFEs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ActivitiesAndEventsFEs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tittle,Descreption,img,serial")] ActivitiesAndEventsFE activitiesAndEventsFE)
        {
            if (ModelState.IsValid)
            {
                activitiesAndEventsFE.Id = Guid.NewGuid();
                _context.Add(activitiesAndEventsFE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(activitiesAndEventsFE);
        }

        // GET: ActivitiesAndEventsFEs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activitiesAndEventsFE = await _context.ActivitiesAndEventsFEs.FindAsync(id);
            if (activitiesAndEventsFE == null)
            {
                return NotFound();
            }
            return View(activitiesAndEventsFE);
        }

        // POST: ActivitiesAndEventsFEs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Tittle,Descreption,img,serial")] ActivitiesAndEventsFE activitiesAndEventsFE)
        {
            if (id != activitiesAndEventsFE.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(activitiesAndEventsFE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActivitiesAndEventsFEExists(activitiesAndEventsFE.Id))
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
            return View(activitiesAndEventsFE);
        }

        // GET: ActivitiesAndEventsFEs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activitiesAndEventsFE = await _context.ActivitiesAndEventsFEs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activitiesAndEventsFE == null)
            {
                return NotFound();
            }

            return View(activitiesAndEventsFE);
        }

        // POST: ActivitiesAndEventsFEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var activitiesAndEventsFE = await _context.ActivitiesAndEventsFEs.FindAsync(id);
            _context.ActivitiesAndEventsFEs.Remove(activitiesAndEventsFE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActivitiesAndEventsFEExists(Guid id)
        {
            return _context.ActivitiesAndEventsFEs.Any(e => e.Id == id);
        }
    }
}
