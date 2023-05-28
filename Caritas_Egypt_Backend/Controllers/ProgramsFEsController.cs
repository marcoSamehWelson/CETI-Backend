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
    public class ProgramsFEsController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public ProgramsFEsController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: ProgramsFEs
        public async Task<IActionResult> Index()
        {
        //    If Not IsNothing(LoginData) Then
        //    Session("Page") = PageType.Shifts
        //    Return View()

        //Else
        //    Return RedirectToAction("Logout", "Account", Nothing)
        //End If
            var prog = await _context.ProgramsFEs.Include(s => s.programsCategoryFE).ToListAsync();
            return View(prog);
        }

        // GET: ProgramsFEs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programsFE = await _context.ProgramsFEs.Include(s => s.programsCategoryFE)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programsFE == null)
            {
                return NotFound();
            }

            return View(programsFE);
        }

        // GET: ProgramsFEs/Create
        public IActionResult Create()
        {
            ViewData["ProgramsCategoryFEId"] = new SelectList(_context.ProgramsCategoryFEs, "Id", "Tittle");

            return View();

        }

        // POST: ProgramsFEs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tittle,Descreption,img,ProgramsCategoryFEId")] ProgramsFE programsFE)
        {
            if (ModelState.IsValid)
            {
                programsFE.Id = Guid.NewGuid();
                _context.Add(programsFE);
                ViewData["ProgramsCategoryFEId"] = new SelectList(_context.ProgramsCategoryFEs, "Id", "Tittle", programsFE.Id);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(programsFE);
        }

        // GET: ProgramsFEs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programsFE = await _context.ProgramsFEs.FindAsync(id);
            if (programsFE == null)
            {
                return NotFound();
            }
            ViewData["ProgramsCategoryFEId"] = new SelectList(_context.ProgramsCategoryFEs, "Id", "Tittle", programsFE.Id);

            return View(programsFE);
        }

        // POST: ProgramsFEs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Tittle,Descreption,img,ProgramsCategoryFEId")] ProgramsFE programsFE)
        {
            if (id != programsFE.Id)
            {
                return NotFound();
            }
            ViewData["ProgramsCategoryFEId"] = new SelectList(_context.ProgramsCategoryFEs, "Id", "Tittle", programsFE.Id);

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programsFE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramsFEExists(programsFE.Id))
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
            return View(programsFE);
        }

        // GET: ProgramsFEs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programsFE = await _context.ProgramsFEs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programsFE == null)
            {
                return NotFound();
            }

            return View(programsFE);
        }

        // POST: ProgramsFEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var programsFE = await _context.ProgramsFEs.FindAsync(id);
            _context.ProgramsFEs.Remove(programsFE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramsFEExists(Guid id)
        {
            return _context.ProgramsFEs.Any(e => e.Id == id);
        }
    }
}
