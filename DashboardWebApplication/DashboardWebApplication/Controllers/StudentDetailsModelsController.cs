using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DashboardWebApplication.Models;

namespace DashboardWebApplication.Controllers
{
    public class StudentDetailsModelsController : Controller
    {
        private readonly StudentDBContext _context;

        public StudentDetailsModelsController(StudentDBContext context)
        {
            _context = context;
        }

        // GET: StudentDetailsModels
        public async Task<IActionResult> Index()
        {
              return _context.Students != null ? 
                          View(await _context.Students.ToListAsync()) :
                          Problem("Entity set 'StudentDBContext.Students'  is null.");
        }

        // GET: StudentDetailsModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var studentDetailsModel = await _context.Students
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (studentDetailsModel == null)
            {
                return NotFound();
            }

            return View(studentDetailsModel);
        }

        // GET: StudentDetailsModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentDetailsModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,FirstName,LastName,RollNo,Contact,Address")] StudentDetailsModel studentDetailsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentDetailsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentDetailsModel);
        }

        // GET: StudentDetailsModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var studentDetailsModel = await _context.Students.FindAsync(id);
            if (studentDetailsModel == null)
            {
                return NotFound();
            }
            return View(studentDetailsModel);
        }

        // POST: StudentDetailsModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,FirstName,LastName,RollNo,Contact,Address")] StudentDetailsModel studentDetailsModel)
        {
            if (id != studentDetailsModel.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentDetailsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentDetailsModelExists(studentDetailsModel.StudentId))
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
            return View(studentDetailsModel);
        }

        // GET: StudentDetailsModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var studentDetailsModel = await _context.Students
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (studentDetailsModel == null)
            {
                return NotFound();
            }

            return View(studentDetailsModel);
        }

        // POST: StudentDetailsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Students == null)
            {
                return Problem("Entity set 'StudentDBContext.Students'  is null.");
            }
            var studentDetailsModel = await _context.Students.FindAsync(id);
            if (studentDetailsModel != null)
            {
                _context.Students.Remove(studentDetailsModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentDetailsModelExists(int id)
        {
          return (_context.Students?.Any(e => e.StudentId == id)).GetValueOrDefault();
        }
    }
}
