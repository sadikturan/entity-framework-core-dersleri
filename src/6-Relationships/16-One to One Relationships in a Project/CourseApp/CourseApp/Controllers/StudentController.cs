using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Controllers
{
    public class StudentController : Controller
    {
        private DataContext _context;
        public StudentController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Students.Include(i => i.Address));
        }

        public IActionResult Create()
        {
            return View("StudentEditor");
        }

        public IActionResult Edit(int id)
        {
            return View("StudentEditor",
                 _context
                    .Students
                    .Include(i => i.Address)
                    .FirstOrDefault(i => i.Id == id));
        }

        [HttpPost]
        public IActionResult Edit(Student entity)
        {
            if (entity.Id == 0)
            {
                _context.Students.Add(entity);
            }
            else
            {
                _context.Students.Update(entity);
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}