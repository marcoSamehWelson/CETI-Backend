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
    public class TypeOfDisabilitiesController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public TypeOfDisabilitiesController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: TypeOfDisabilities
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypeOfDisabilitys.ToListAsync());
        }

        // GET: TypeOfDisabilities/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfDisability = await _context.TypeOfDisabilitys
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeOfDisability == null)
            {
                return NotFound();
            }

            return View(typeOfDisability);
        }

        // GET: TypeOfDisabilities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypeOfDisabilities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] TypeOfDisability typeOfDisability)
        {
            if (ModelState.IsValid)
            {
                typeOfDisability.Id = Guid.NewGuid();
                _context.Add(typeOfDisability);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeOfDisability);
        }

        // GET: TypeOfDisabilities/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfDisability = await _context.TypeOfDisabilitys.FindAsync(id);
            if (typeOfDisability == null)
            {
                return NotFound();
            }
            return View(typeOfDisability);
        }

        // POST: TypeOfDisabilities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name")] TypeOfDisability typeOfDisability)
        {
            if (id != typeOfDisability.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeOfDisability);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeOfDisabilityExists(typeOfDisability.Id))
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
            return View(typeOfDisability);
        }

        // GET: TypeOfDisabilities/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfDisability = await _context.TypeOfDisabilitys
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeOfDisability == null)
            {
                return NotFound();
            }

            return View(typeOfDisability);
        }

        // POST: TypeOfDisabilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var typeOfDisability = await _context.TypeOfDisabilitys.FindAsync(id);
            _context.TypeOfDisabilitys.Remove(typeOfDisability);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeOfDisabilityExists(Guid id)
        {
            return _context.TypeOfDisabilitys.Any(e => e.Id == id);
        }
    }
}
