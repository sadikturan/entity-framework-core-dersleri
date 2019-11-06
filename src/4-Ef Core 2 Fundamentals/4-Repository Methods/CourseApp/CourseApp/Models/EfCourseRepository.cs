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
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCourses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesByActive(bool isActive)
        {
            return context.Courses.Where(i => i.isActive == isActive).ToList();
        }

        public void UpdateCourse(Course updatedCourse)
        {
            throw new NotImplementedException();
        }
    }
}
