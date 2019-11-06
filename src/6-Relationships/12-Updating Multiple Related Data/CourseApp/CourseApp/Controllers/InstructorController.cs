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
        public InstructorController(IInstructorRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            ViewBag.InstructorEditId = TempData["InstructorEditId"];
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
    }
}