using CourseApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public interface IInstructorRepository : IGenericRepository<Instructor>
    {
        IEnumerable<Instructor> GetTopInstructor();
    }
}
