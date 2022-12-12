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
    public class ProjectsFEsController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public ProjectsFEsController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: ProjectsFEs
        public async Task<IActionResult> Index()
        {
            var cETICaretasEgyptContext = _context.ProjectsFEs.Include(p => p.projectsCategoryFE);
            return View(await cETICaretasEgyptContext.ToListAsync());
        }

        // GET: ProjectsFEs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectsFE = await _context.ProjectsFEs
                .Include(p => p.projectsCategoryFE)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectsFE == null)
            {
                return NotFound();
            }

            return View(projectsFE);
        }

        // GET: ProjectsFEs/Create
        public IActionResult Create()
        {
            ViewData["ProjectsCategoryFEId"] = new SelectList(_context.ProjectsCategoryFEs, "Id", "Tittle");
            return View();
        }

        // POST: ProjectsFEs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tittle,Paragraph,Year,Location,Objectives,Mainactivities,Partners,TargetgrouporBeneficiaries,ProjectsCategoryFEId")] ProjectsFE projectsFE)
        {
            if (ModelState.IsValid)
            {
                projectsFE.Id = Guid.NewGuid();
                _context.Add(projectsFE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectsCategoryFEId"] = new SelectList(_context.ProjectsCategoryFEs, "Id", "Tittle", projectsFE.ProjectsCategoryFEId);
            return View(projectsFE);
        }

        // GET: ProjectsFEs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectsFE = await _context.ProjectsFEs.FindAsync(id);
            if (projectsFE == null)
            {
                return NotFound();
            }
            ViewData["ProjectsCategoryFEId"] = new SelectList(_context.ProjectsCategoryFEs, "Id", "Tittle", projectsFE.ProjectsCategoryFEId);
            return View(projectsFE);
        }

        // POST: ProjectsFEs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Tittle,Paragraph,Year,Location,Objectives,Mainactivities,Partners,TargetgrouporBeneficiaries,ProjectsCategoryFEId")] ProjectsFE projectsFE)
        {
            if (id != projectsFE.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectsFE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectsFEExists(projectsFE.Id))
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
            ViewData["ProjectsCategoryFEId"] = new SelectList(_context.ProjectsCategoryFEs, "Id", "Tittle", projectsFE.ProjectsCategoryFEId);
            return View(projectsFE);
        }

        // GET: ProjectsFEs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectsFE = await _context.ProjectsFEs
                .Include(p => p.projectsCategoryFE)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectsFE == null)
            {
                return NotFound();
            }

            return View(projectsFE);
        }

        // POST: ProjectsFEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var projectsFE = await _context.ProjectsFEs.FindAsync(id);
            _context.ProjectsFEs.Remove(projectsFE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectsFEExists(Guid id)
        {
            return _context.ProjectsFEs.Any(e => e.Id == id);
        }
    }
}
