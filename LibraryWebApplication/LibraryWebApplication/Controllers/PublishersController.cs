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

namespace LibraryWebApplication.Controllers
{
    public class PublishersController : Controller
    {
        private readonly PublisherService _publisherService;

        public PublishersController(PublisherService publisherService)
        {
            _publisherService = publisherService;
        }
        // GET: Publishers
        public IActionResult Index()
        {
            return View(_publisherService.GetPublisher());
        }

        // GET: Publishers/Details/5
        public IActionResult Details(string name)
        {
            if (name == null)
            {
                return NotFound();
            }

            var publisher = _publisherService.GetPublisher()
                .FirstOrDefault(m => m.publisher_name == name);
            if (publisher == null)
            {
                return NotFound();
            }

            return View(publisher);
        }

        // GET: Publishers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Publishers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("publisher_name,address")] Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                _publisherService.AddPublisher(publisher);
                _publisherService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(publisher);
        }

        // GET: Publishers/Edit/5
        public IActionResult Edit(string name)
        {
            if (name == null)
            {
                return NotFound();
            }

            var publisher =  _publisherService.GetPublisher().FirstOrDefault(m => m.publisher_name == name);
            if (publisher == null)
            {
                return NotFound();
            }
            return View(publisher);
        }

        // POST: Publishers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string name, [Bind("publisher_name,address")] Publisher publisher)
        {
            if (name != publisher.publisher_name)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _publisherService.UpdatePublisher(publisher);
                    _publisherService.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PublisherExists(publisher.publisher_name))
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
            return View(publisher);
        }

        // GET: Publishers/Delete/5
        public IActionResult Delete(string name)
        {
            if (name == null)
            {
                return NotFound();
            }

            var publisher = _publisherService.GetPublisher()
                .FirstOrDefault(m => m.publisher_name == name);
            if (publisher == null)
            {
                return NotFound();
            }

            return View(publisher);
        }

        // POST: Publishers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string name)
        {
            var publisher = _publisherService.GetPublisherByCondition(b => b.publisher_name == name).FirstOrDefault();
            _publisherService.DeletePublisher(publisher);
            _publisherService.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool PublisherExists(string id)
        {
            return _publisherService.GetPublisher().Any(e => e.publisher_name == id);
        }
    }
}
