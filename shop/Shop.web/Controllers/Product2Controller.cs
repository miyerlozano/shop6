using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shop.web.Data;

namespace Shop.web.Controllers
{
    public class Product2Controller : Controller
    {
        private readonly DataContext _context;

        public Product2Controller(DataContext context)
        {
            _context = context;
        }

        // GET: Product2
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products2.ToListAsync());
        }

        // GET: Product2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product2 = await _context.Products2
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product2 == null)
            {
                return NotFound();
            }

            return View(product2);
        }

        // GET: Product2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,ImageUrl,LastPurchase,LastSale,IsAvailabe,Stock")] Product2 product2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product2);
        }

        // GET: Product2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product2 = await _context.Products2.FindAsync(id);
            if (product2 == null)
            {
                return NotFound();
            }
            return View(product2);
        }

        // POST: Product2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,ImageUrl,LastPurchase,LastSale,IsAvailabe,Stock")] Product2 product2)
        {
            if (id != product2.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Product2Exists(product2.Id))
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
            return View(product2);
        }

        // GET: Product2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product2 = await _context.Products2
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product2 == null)
            {
                return NotFound();
            }

            return View(product2);
        }

        // POST: Product2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product2 = await _context.Products2.FindAsync(id);
            _context.Products2.Remove(product2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Product2Exists(int id)
        {
            return _context.Products2.Any(e => e.Id == id);
        }
    }
}
