using CourseApp.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class EfInstructorRepository : GenericRepository<Instructor>, IInstructorRepository
    {
        private DataContext _context;
        public EfInstructorRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Instructor> GetTopInstructor()
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Instructor> GetAll()
        {
            return _context.Instructors.Include(i => i.Courses);
        }
    }
}