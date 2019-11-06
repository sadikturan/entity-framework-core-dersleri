using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class EfCourseRepository : ICourseRepository
    {
        private DataContext context;
        public EfCourseRepository(DataContext _context)
        {
            context = _context;
        }

        public IQueryable<Course> Courses => context.Courses;

        public void CreateCourse(Course newCourse)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse(int courseid)
        {
            throw new NotImplementedException();
        }

        public Course GetById(int courseid)
        {
            return context.Courses.Find(courseid);
        }

        public IEnumerable<Course> GetCourses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesByActive(bool isActive)
        {
            return context.Courses.Where(i => i.isActive == isActive).ToList();
        }

        public void UpdateCourse(Course updatedCourse, Course originalCourse = null)
        {
            if (originalCourse == null)
            {
                originalCourse = context.Courses.Find(updatedCourse.Id);
            }
            else
            {
                context.Courses.Attach(originalCourse);
            } 

            originalCourse.Name = updatedCourse.Name;
            originalCourse.Description = updatedCourse.Description;
            originalCourse.Price = updatedCourse.Price;
            originalCourse.isActive = updatedCourse.isActive;

            EntityEntry entry = context.Entry(originalCourse);

            // Modified,Unchanged,Added,Deleted,Detached
            Console.WriteLine($"Entity State : {entry.State}");

            foreach (var property in new string[] { "Name", "Description", "Price", "isActive" })
            {
                Console.WriteLine($"{property} - old : {entry.OriginalValues[property]}  new : {entry.CurrentValues[property]}");
            }

            context.SaveChanges();

        }
    }
}
