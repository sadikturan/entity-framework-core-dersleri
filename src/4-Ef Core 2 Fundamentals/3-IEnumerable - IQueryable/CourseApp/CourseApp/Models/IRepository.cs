using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public interface IRepository
    {
        IEnumerable<Request> Requests { get; }
        IQueryable<Course> Courses { get; }
    }
}
