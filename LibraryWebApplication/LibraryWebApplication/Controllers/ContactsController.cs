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
    public class ContactsController : Controller
    {
        private readonly ContactService _contactService;

        public ContactsController(ContactService contactService)
        {
            _contactService = contactService;
        }

        // GET: Contacts
        public IActionResult Index()
        {
            var messages = _contactService.GetMessages();
            return View(messages);
        }

        // GET: Contacts/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = _contactService.GetMessages().FirstOrDefault(m => m.message_id == id);
            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }

        // GET: Contacts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("message_id,first_name,last_name,email,subject")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.AddMessage(contact);
                _contactService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        // GET: Contacts/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = _contactService.GetMessages().FirstOrDefault(m => m.message_id == id);
            if (message == null)
            {
                return NotFound();
            }
            return View(message);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("message_id,first_name,last_name,email,subject")] Contact contact)
        {
            if (id != contact.message_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _contactService.UpdateMessage(contact);
                    _contactService.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.message_id))
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
            return View(contact);
        }

        // GET: Contacts/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = _contactService.GetMessages().FirstOrDefault(m => m.message_id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var message = _contactService.GetMessagesByCondition(b => b.message_id == id).FirstOrDefault();
            _contactService.DeleteMessage(message);
            _contactService.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(int id)
        {
            return _contactService.GetMessages().Any(e => e.message_id == id);
        }
    }
}
