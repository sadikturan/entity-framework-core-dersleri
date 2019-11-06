using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        private ICourseRepository repository;
        public CourseController(ICourseRepository _repository)
        {
            repository = _repository;
        }
        public IActionResult Index()
        {
            var courses = repository.GetCoursesByActive(true);
            ViewBag.CourseCount = courses.Count();

            return View(courses);
        }


        public IActionResult Edit(int id)
        {
            return View(repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Course entity,Course original)
        {
            repository.UpdateCourse(entity, original);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}