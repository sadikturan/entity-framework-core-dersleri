using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public interface ICourseRepository
    {      
        IQueryable<Course> Courses { get; }

        Course GetById(int courseid);
        IEnumerable<Course> GetCourses();
        IEnumerable<Course> GetCoursesByActive(bool isActive);
        void CreateCourse(Course newCourse);
        void UpdateCourse(Course updatedCourse);
        void DeleteCourse(int courseid);

    }
}
