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
    public class ProjectsCategoryFEsController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public ProjectsCategoryFEsController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: ProjectsCategoryFEs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectsCategoryFEs.ToListAsync());
        }

        // GET: ProjectsCategoryFEs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectsCategoryFE = await _context.ProjectsCategoryFEs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectsCategoryFE == null)
            {
                return NotFound();
            }

            return View(projectsCategoryFE);
        }

        // GET: ProjectsCategoryFEs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectsCategoryFEs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tittle,Descreption,img,serial")] ProjectsCategoryFE projectsCategoryFE)
        {
            if (ModelState.IsValid)
            {
                projectsCategoryFE.Id = Guid.NewGuid();
                _context.Add(projectsCategoryFE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectsCategoryFE);
        }

        // GET: ProjectsCategoryFEs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectsCategoryFE = await _context.ProjectsCategoryFEs.FindAsync(id);
            if (projectsCategoryFE == null)
            {
                return NotFound();
            }
            return View(projectsCategoryFE);
        }

        // POST: ProjectsCategoryFEs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Tittle,Descreption,img,serial")] ProjectsCategoryFE projectsCategoryFE)
        {
            if (id != projectsCategoryFE.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectsCategoryFE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectsCategoryFEExists(projectsCategoryFE.Id))
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
            return View(projectsCategoryFE);
        }

        // GET: ProjectsCategoryFEs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectsCategoryFE = await _context.ProjectsCategoryFEs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectsCategoryFE == null)
            {
                return NotFound();
            }

            return View(projectsCategoryFE);
        }

        // POST: ProjectsCategoryFEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var projectsCategoryFE = await _context.ProjectsCategoryFEs.FindAsync(id);
            _context.ProjectsCategoryFEs.Remove(projectsCategoryFE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectsCategoryFEExists(Guid id)
        {
            return _context.ProjectsCategoryFEs.Any(e => e.Id == id);
        }
    }
}
