﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Caritas_Egypt_Backend.Models;

namespace Caritas_Egypt_Backend.Controllers
{
    public class ServicesController : Controller
    {
        private readonly CETICaretasEgyptContext _context;

        public ServicesController(CETICaretasEgyptContext context)
        {
            _context = context;
        }

        // GET: Services
        public async Task<IActionResult> Index(string? name)
        {
            if (name != null)
            {

                return View(await _context.Services.Where(s => s.Name == name).ToListAsync());

            }
            else
            {
                return View(await _context.Services.ToListAsync());
            }
        }

        // GET: Services/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .FirstOrDefaultAsync(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            ViewData["languageId"] = new SelectList(_context.Languages, "Id", "Name");

            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name");
            ViewData["SessionTimeId"] = new SelectList(_context.SessionTimes, "Id", "Name");
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,TrainerInsentive,NightTrainerInsentive,ServiceTypeId,languageId,SessionTimeId")] Service service)
        {
            if (ModelState.IsValid)
            {
                service.Id = Guid.NewGuid();
                _context.Add(service);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["languageId"] = new SelectList(_context.Languages, "Id", "Name",service.languageId);
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", service.ServiceTypeId);
            ViewData["SessionTimeId"] = new SelectList(_context.SessionTimes, "Id", "Name", service.SessionTimeId);
            return View(service);
        }

        // GET: Services/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            ViewData["languageId"] = new SelectList(_context.Languages, "Id", "Name", service.languageId);
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", service.ServiceTypeId);
            ViewData["SessionTimeId"] = new SelectList(_context.SessionTimes, "Id", "Name", service.SessionTimeId);
            return View(service);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,TrainerInsentive,NightTrainerInsentive,ServiceTypeId,languageId,SessionTimeId")] Service service)
        {
            if (id != service.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(service);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceExists(service.Id))
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
            ViewData["languageId"] = new SelectList(_context.Languages, "Id", "Name", service.languageId);
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", service.ServiceTypeId);
            ViewData["SessionTimeId"] = new SelectList(_context.SessionTimes, "Id", "Name", service.SessionTimeId);
            return View(service);
        }

        // GET: Services/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .FirstOrDefaultAsync(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var service = await _context.Services.FindAsync(id);
            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(Guid id)
        {
            return _context.Services.Any(e => e.Id == id);
        }
    }
}
