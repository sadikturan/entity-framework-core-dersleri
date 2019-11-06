using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public interface IInstructorRepository
    {
        Instructor Get(int id);
        IEnumerable<Instructor> GetAll();
        void Delete(int id);
        void Update(Instructor entity);
        void Insert(Instructor entity);
    }
}
