using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class EfRepository : IRepository
    {
        private DataContext context;
        public EfRepository(DataContext _context)
        {
            context = _context;
        }

        public IEnumerable<Request> Requests => context.Requests;

        public IQueryable<Course> Courses => context.Courses;
    }
}
