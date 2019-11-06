using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class InstructorController : Controller
    {
        private IInstructorRepository _repository;
        private ICourseRepository _courseRepository;
        public InstructorController(IInstructorRepository repository, ICourseRepository courseRepository)
        {
            _repository = repository;
            _courseRepository = courseRepository;
        }

        public IActionResult Index()
        {
            ViewBag.InstructorEditId = TempData["InstructorEditId"];
            ViewBag.InstructorCreateId = TempData["InstructorCreateId"];
            ViewBag.InstructorChangeId = TempData["InstructorChangeId"];
            return View(_repository.GetAll());
        }

        public IActionResult Edit(int id)
        {
            TempData["InstructorEditId"] = id;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Instructor entity)
        {
            _repository.Update(entity);
            return RedirectToAction("Index");
        }

        public IActionResult Create(int id)
        {
            TempData["InstructorCreateId"] = id;
            return RedirectToAction("Index");
        }

        public IActionResult Change(int id)
        {
            TempData["InstructorChangeId"] = id;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Change(int Id, Course[] Courses)
        {
            _courseRepository.UpdateAll(Id, Courses);
            return RedirectToAction("Index");
        }
    }
}