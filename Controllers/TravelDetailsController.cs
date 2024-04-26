using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Travelogue03.Data;
using Travelogue03.Models;

namespace Travelogue03.Controllers
{
    public class TravelDetailsController : Controller
    {
        private readonly Travelogue03Context _context;

        public TravelDetailsController(Travelogue03Context context)
        {
            _context = context;
        }

        // GET: TravelDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.TravelDetails.ToListAsync());
        }

        // GET: TravelDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelDetails = await _context.TravelDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (travelDetails == null)
            {
                return NotFound();
            }

            return View(travelDetails);
        }

        // GET: TravelDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TravelDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,PhoneNumber,Destination,StartDate,EndDate,Budget,NumPeople,SpecialRequests")] TravelDetails travelDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(travelDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(travelDetails);
        }

        // GET: TravelDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelDetails = await _context.TravelDetails.FindAsync(id);
            if (travelDetails == null)
            {
                return NotFound();
            }
            return View(travelDetails);
        }

        // POST: TravelDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,PhoneNumber,Destination,StartDate,EndDate,Budget,NumPeople,SpecialRequests")] TravelDetails travelDetails)
        {
            if (id != travelDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(travelDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelDetailsExists(travelDetails.Id))
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
            return View(travelDetails);
        }

        // GET: TravelDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travelDetails = await _context.TravelDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (travelDetails == null)
            {
                return NotFound();
            }

            return View(travelDetails);
        }

        // POST: TravelDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var travelDetails = await _context.TravelDetails.FindAsync(id);
            if (travelDetails != null)
            {
                _context.TravelDetails.Remove(travelDetails);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelDetailsExists(int id)
        {
            return _context.TravelDetails.Any(e => e.Id == id);
        }
    }
}
