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
    public class OurPartnersFEsController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public OurPartnersFEsController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: OurPartnersFEs
        public async Task<IActionResult> Index()
        {
            return View(await _context.OurPartnersFEs.ToListAsync());
        }

        // GET: OurPartnersFEs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourPartnersFE = await _context.OurPartnersFEs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ourPartnersFE == null)
            {
                return NotFound();
            }

            return View(ourPartnersFE);
        }

        // GET: OurPartnersFEs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OurPartnersFEs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tittle,Descreption,img,serial")] OurPartnersFE ourPartnersFE)
        {
            if (ModelState.IsValid)
            {
                ourPartnersFE.Id = Guid.NewGuid();
                _context.Add(ourPartnersFE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ourPartnersFE);
        }

        // GET: OurPartnersFEs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourPartnersFE = await _context.OurPartnersFEs.FindAsync(id);
            if (ourPartnersFE == null)
            {
                return NotFound();
            }
            return View(ourPartnersFE);
        }

        // POST: OurPartnersFEs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Tittle,Descreption,img,serial")] OurPartnersFE ourPartnersFE)
        {
            if (id != ourPartnersFE.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ourPartnersFE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OurPartnersFEExists(ourPartnersFE.Id))
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
            return View(ourPartnersFE);
        }

        // GET: OurPartnersFEs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourPartnersFE = await _context.OurPartnersFEs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ourPartnersFE == null)
            {
                return NotFound();
            }

            return View(ourPartnersFE);
        }

        // POST: OurPartnersFEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var ourPartnersFE = await _context.OurPartnersFEs.FindAsync(id);
            _context.OurPartnersFEs.Remove(ourPartnersFE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OurPartnersFEExists(Guid id)
        {
            return _context.OurPartnersFEs.Any(e => e.Id == id);
        }
    }
}
