using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class EfInstructorRepository : IInstructorRepository
    {
        private DataContext _context;
        public EfInstructorRepository(DataContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Instructor Get(int id)
        {
            return _context.Instructors.Find(id);
        }

        public IEnumerable<Instructor> GetAll()
        {
            return _context.Instructors;
        }

        public void Insert(Instructor entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor entity)
        {
            throw new NotImplementedException();
        }
    }
}
