using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Controllers
{
    public class StudentCourseController : Controller
    {
        private DataContext _context;
        public StudentCourseController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new StudentCourseModel();

            model.Courses = _context
                .Courses
                .Include(i => i.StudentCourses)
                .ThenInclude(i => i.Student)
                .Where(i => i.isActive)
                .ToList();

            model.Students = _context
                .Students
                .Include(i => i.StudentCourses)
                .ThenInclude(i => i.Course)
                .Where(i => i.StudentCourses
                            .Any(a => a.Course.isActive))
                .ToList();

            return View(model);
        }
    }
}