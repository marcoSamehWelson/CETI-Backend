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
    public class JobFEsController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public JobFEsController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: JobFEs
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobFEs.ToListAsync());
        }

        // GET: JobFEs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobFE = await _context.JobFEs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobFE == null)
            {
                return NotFound();
            }

            return View(jobFE);
        }

        // GET: JobFEs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobFEs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tittle,Descreption,img,serial")] JobFE jobFE)
        {
            if (ModelState.IsValid)
            {
                jobFE.Id = Guid.NewGuid();
                _context.Add(jobFE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobFE);
        }

        // GET: JobFEs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobFE = await _context.JobFEs.FindAsync(id);
            if (jobFE == null)
            {
                return NotFound();
            }
            return View(jobFE);
        }

        // POST: JobFEs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Tittle,Descreption,img,serial")] JobFE jobFE)
        {
            if (id != jobFE.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobFE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobFEExists(jobFE.Id))
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
            return View(jobFE);
        }

        // GET: JobFEs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobFE = await _context.JobFEs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobFE == null)
            {
                return NotFound();
            }

            return View(jobFE);
        }

        // POST: JobFEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var jobFE = await _context.JobFEs.FindAsync(id);
            _context.JobFEs.Remove(jobFE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobFEExists(Guid id)
        {
            return _context.JobFEs.Any(e => e.Id == id);
        }
    }
}
