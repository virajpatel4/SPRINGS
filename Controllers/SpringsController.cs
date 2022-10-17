using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcSprings.Models;
using Springs.Data;

namespace Springs.Controllers
{
    public class SpringsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SpringsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Springs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Spring.ToListAsync());
        }

        // GET: Springs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spring = await _context.Spring
                .FirstOrDefaultAsync(m => m.Id == id);
            if (spring == null)
            {
                return NotFound();
            }

            return View(spring);
        }

        // GET: Springs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Springs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Model,Color,Material,ManufacturingDate,Price,IndustryName")] Spring spring)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spring);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spring);
        }

        // GET: Springs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spring = await _context.Spring.FindAsync(id);
            if (spring == null)
            {
                return NotFound();
            }
            return View(spring);
        }

        // POST: Springs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Model,Color,Material,ManufacturingDate,Price,IndustryName")] Spring spring)
        {
            if (id != spring.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spring);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpringExists(spring.Id))
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
            return View(spring);
        }

        // GET: Springs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spring = await _context.Spring
                .FirstOrDefaultAsync(m => m.Id == id);
            if (spring == null)
            {
                return NotFound();
            }

            return View(spring);
        }

        // POST: Springs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spring = await _context.Spring.FindAsync(id);
            _context.Spring.Remove(spring);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpringExists(int id)
        {
            return _context.Spring.Any(e => e.Id == id);
        }
    }
}
