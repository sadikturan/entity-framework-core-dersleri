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
            //IEnumerable<Instructor> instructors = _context.Instructors;

            //foreach (var ins in instructors)
            //{
            //    _context.Entry(ins).Collection(i => i.Courses)
            //        .Query()
            //        .Where(i => i.isActive)
            //        .Load();
            //}
            //return instructors;

            _context.Courses.Where(i => i.Instructor != null && i.isActive).Load();
            return _context.Instructors;

        }
    }
}