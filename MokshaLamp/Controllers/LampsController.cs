using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MokshaLamp.Data;
using MokshaLamp.Models;

namespace MokshaLamp.Controllers
{
    public class LampsController : Controller
    {
        private readonly MokshaLampContext _context;

        public LampsController(MokshaLampContext context)
        {
            _context = context;
        }

        // GET: Lamps
        public async Task<IActionResult> Index(string lampColor, string searchString) // Adds search box
        {
            IQueryable<string> colorQuery = from m in _context.Lamp
                                            orderby m.Color
                                            select m.Color;

            var lamps = from m in _context.Lamp
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                lamps = lamps.Where(s => s.Category.Contains(searchString));  // Search by category
            }

            if (!string.IsNullOrEmpty(lampColor))
            {
                lamps = lamps.Where(x => x.Color == lampColor);
            }

            var lampColorVM = new LampColorViewModel
            {
                Colors = new SelectList(await colorQuery.Distinct().ToListAsync()),
                Lamps = await lamps.ToListAsync()
            };

            return View(lampColorVM);
        }

        // GET: Lamps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lamp = await _context.Lamp
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lamp == null)
            {
                return NotFound();
            }

            return View(lamp);
        }

        // GET: Lamps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lamps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Category,ManufactureDate,Color,Material,Dimension,Price")] Lamp lamp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lamp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lamp);
        }

        // GET: Lamps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lamp = await _context.Lamp.FindAsync(id);
            if (lamp == null)
            {
                return NotFound();
            }
            return View(lamp);
        }

        // POST: Lamps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Category,ManufactureDate,Color,Material,Dimension,Price")] Lamp lamp)
        {
            if (id != lamp.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lamp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LampExists(lamp.Id))
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
            return View(lamp);
        }

        // GET: Lamps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lamp = await _context.Lamp
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lamp == null)
            {
                return NotFound();
            }

            return View(lamp);
        }

        // POST: Lamps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lamp = await _context.Lamp.FindAsync(id);
            _context.Lamp.Remove(lamp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LampExists(int id)
        {
            return _context.Lamp.Any(e => e.Id == id);
        }
    }
}
