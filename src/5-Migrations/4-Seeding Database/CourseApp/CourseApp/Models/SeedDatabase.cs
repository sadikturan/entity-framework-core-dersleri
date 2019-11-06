using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public static class SeedDatabase
    {
        public static void Seed(DbContext context)
        {
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context is DataContext)
                {
                    DataContext _context = context as DataContext;

                    if (_context.Courses.Count() == 0)
                    {
                        _context.Courses.AddRange(Courses);
                    }

                    if (_context.Instructors.Count() == 0)
                    {
                        _context.Instructors.AddRange(Instructors);
                    }

                    context.SaveChanges();
                }
            }
        }

        private static Course[] Courses = {
            new Course(){ Name="Html", Price=10, Description="about html", isActive=true},
            new Course(){ Name="Css", Price=10, Description="about Css", isActive=true},
            new Course(){ Name="Javascipt", Price=20, Description="about Javascipt", isActive=false},
            new Course(){ Name="NodeJs", Price=10, Description="about NodeJs", isActive=true},
            new Course(){ Name="Angular", Price=30, Description="about Angular", isActive=false},
            new Course(){ Name="React", Price=20, Description="about React", isActive=false},
            new Course(){ Name="Mvc", Price=10, Description="about Mvc", isActive=false}
        };

        private static Instructor[] Instructors = {
            new Instructor(){  Name="Ahmet", City="İstanbul"},
            new Instructor(){  Name="Mehmet", City="İstanbul"},
            new Instructor(){  Name="Ali", City="İstanbul"},
            new Instructor(){  Name="Hasan", City="Kocaeli"}
        };
    }
}
