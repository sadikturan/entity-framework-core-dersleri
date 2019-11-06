using Microsoft.EntityFrameworkCore;
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

        public int CreateCourse(Course newCourse)
        {
            context.Courses.Add(newCourse);
            context.SaveChanges();

            return newCourse.Id;
        }

        public void DeleteCourse(int courseid)
        {
            context.Courses.Remove(new Course() { Id = courseid });
            context.SaveChanges();
        }

        public Course GetById(int courseid)
        {
            return context.Courses.Include(i => i.Instructor).FirstOrDefault(i => i.Id == courseid);
        }

        public IEnumerable<Course> GetCourses()
        {
            return context.Courses;
        }

        public IEnumerable<Course> GetCoursesByActive(bool isActive)
        {
            return context.Courses.Where(i => i.isActive == isActive).ToList();
        }

        public IEnumerable<Course> GetCoursesByFilters(string name = null, decimal? price = null, string isActive = null)
        {
            IQueryable<Course> query = context.Courses;

            if (name != null)
            {
                query = query.Where(i => i.Name.ToLower().Contains(name.ToLower()));
            }

            if (price != null)
            {
                query = query.Where(i => i.Price >= price);
            }

            if (isActive == "on")
            {
                query = query.Where(i => i.isActive == true);
            }

            return query.Include(i => i.Instructor).ToList();
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
