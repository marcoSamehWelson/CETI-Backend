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
    public class ProgramsCategoryFEsController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public ProgramsCategoryFEsController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: ProgramsCategoryFEs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProgramsCategoryFEs.ToListAsync());
        }

        // GET: ProgramsCategoryFEs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programsCategoryFE = await _context.ProgramsCategoryFEs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programsCategoryFE == null)
            {
                return NotFound();
            }

            return View(programsCategoryFE);
        }

        // GET: ProgramsCategoryFEs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProgramsCategoryFEs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tittle,Descreption,img")] ProgramsCategoryFE programsCategoryFE)
        {
            if (ModelState.IsValid)
            {
                programsCategoryFE.Id = Guid.NewGuid();
                _context.Add(programsCategoryFE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(programsCategoryFE);
        }

        // GET: ProgramsCategoryFEs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programsCategoryFE = await _context.ProgramsCategoryFEs.FindAsync(id);
            if (programsCategoryFE == null)
            {
                return NotFound();
            }
            return View(programsCategoryFE);
        }

        // POST: ProgramsCategoryFEs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Tittle,Descreption,img")] ProgramsCategoryFE programsCategoryFE)
        {
            if (id != programsCategoryFE.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programsCategoryFE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramsCategoryFEExists(programsCategoryFE.Id))
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
            return View(programsCategoryFE);
        }

        // GET: ProgramsCategoryFEs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programsCategoryFE = await _context.ProgramsCategoryFEs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programsCategoryFE == null)
            {
                return NotFound();
            }

            return View(programsCategoryFE);
        }

        // POST: ProgramsCategoryFEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var programsCategoryFE = await _context.ProgramsCategoryFEs.FindAsync(id);
            _context.ProgramsCategoryFEs.Remove(programsCategoryFE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramsCategoryFEExists(Guid id)
        {
            return _context.ProgramsCategoryFEs.Any(e => e.Id == id);
        }
    }
}
