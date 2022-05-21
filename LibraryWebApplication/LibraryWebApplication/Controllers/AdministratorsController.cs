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
    public class AdministratorsController : Controller
    {
        private readonly AdministratorService _adminService;

        public AdministratorsController(AdministratorService adminService)
        {
            _adminService = adminService;
        }

        // GET: Administrators
        public IActionResult Index()
        {
            var admin = _adminService.GetAdministrator();
            return View(admin);
        }

        // GET: Administrators/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var administrator = _adminService.GetAdministrator().FirstOrDefault(m => m.admin_id == id);
            if (administrator == null)
            {
                return NotFound();
            }

            return View(administrator);
        }

        // GET: Administrators/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrators/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("admin_id,library_id,name,email,password")] Administrator administrator)
        {
            if (ModelState.IsValid)
            {
                _adminService.AddAdministrator(administrator);
                _adminService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(administrator);
        }

        // GET: Administrators/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var administrator = _adminService.GetAdministrator().FirstOrDefault(m => m.admin_id == id);
            if (administrator == null)
            {
                return NotFound();
            }
            return View(administrator);
        }

        // POST: Administrators/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("admin_id,library_id,name,email,password")] Administrator administrator)
        {
            if (id != administrator.admin_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _adminService.UpdateAdministrator(administrator);
                     _adminService.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdministratorExists(administrator.admin_id))
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
            return View(administrator);
        }

        // GET: Administrators/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var administrator = _adminService.GetAdministrator()
                .FirstOrDefault(m => m.admin_id == id);
            if (administrator == null)
            {
                return NotFound();
            }

            return View(administrator);
        }

        // POST: Administrators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var administrator = _adminService.GetAdministratorByCondition(b => b.admin_id == id).FirstOrDefault();
            _adminService.DeleteAdministrator(administrator);
            _adminService.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool AdministratorExists(int id)
        {
            return _adminService.GetAdministrator().Any(e => e.admin_id == id);
        }
    }
}
