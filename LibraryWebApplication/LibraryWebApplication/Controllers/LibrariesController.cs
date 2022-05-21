using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibraryWebApplication.Data;
using LibraryWebApplication.Models;
using LibraryWebApplication.Services;
using Microsoft.AspNetCore.Authorization;

namespace LibraryWebApplication.Controllers
{
    [Authorize]
    public class LibrariesController : Controller
    {
        private readonly LibraryService _libraryService;

        public LibrariesController(LibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        // GET: Libraries
        public IActionResult Index()
        {
            var library = _libraryService.GetLibraries();
            return View(library);
        }

        // GET: Libraries/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var library = _libraryService.GetLibraries().FirstOrDefault(m => m.library_id == id);
            if (library == null)
            {
                return NotFound();
            }

            return View(library);
        }

        // GET: Libraries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Libraries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("library_id,borrowed_book,total_nr_of_books,return_date,message_id")] Library library)
        {
            if (ModelState.IsValid)
            {
                _libraryService.AddLibrary(library);
                _libraryService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(library);
        }

        // GET: Libraries/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var library = _libraryService.GetLibraries().FirstOrDefault(m => m.library_id == id);
            if (library == null)
            {
                return NotFound();
            }
            return View(library);
        }

        // POST: Libraries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("library_id,borrowed_book,total_nr_of_books,return_date,message_id")] Library library)
        {
            if (id != library.library_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _libraryService.UpdateLibrary(library);
                    _libraryService.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LibraryExists(library.library_id))
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
            return View(library);
        }

        // GET: Libraries/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var library = _libraryService.GetLibraries().FirstOrDefault(m => m.library_id == id);
            if (library == null)
            {
                return NotFound();
            }

            return View(library);
        }

        // POST: Libraries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var library = _libraryService.GetLibrariesByCondition(b => b.library_id == id).FirstOrDefault();
            _libraryService.DeleteLibrary(library);
            _libraryService.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool LibraryExists(int id)
        {
            return _libraryService.GetLibraries().Any(e => e.library_id == id);
        }
    }
}
