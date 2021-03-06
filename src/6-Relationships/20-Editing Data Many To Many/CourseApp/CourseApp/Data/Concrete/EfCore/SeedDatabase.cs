﻿using Microsoft.EntityFrameworkCore;
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

                    if (_context.Instructors.Count() == 0)
                    {
                        _context.Instructors.AddRange(Instructors);
                    }

                    if (_context.Courses.Count() == 0)
                    {
                        _context.Courses.AddRange(Courses);
                    }

                    if (_context.Students.Count() == 0)
                    {
                        _context.Students.AddRange(Students);
                    }
                }

                if (context is UserContext)
                {
                    UserContext _context = context as UserContext;

                    if (_context.Users.Count() == 0)
                    {
                        _context.Users.AddRange(Users);
                    }
                }

                context.SaveChanges();
            }
        }

        private static Course[] Courses
        {
            get
            {
                Course[] courses = new Course[]
                {
                    new Course() { Name = "Html", Price = 10, Description = "about html", isActive = true, Instructor=Instructors[0] },
                    new Course() { Name = "Css", Price = 10, Description = "about Css", isActive = true, Instructor=Instructors[1] },
                    new Course() { Name = "Javascipt", Price = 20, Description = "about Javascipt", isActive = false, Instructor=Instructors[2] },
                    new Course() { Name = "NodeJs", Price = 10, Description = "about NodeJs", isActive = true, Instructor=Instructors[3] },
                    new Course() { Name = "Angular", Price = 30, Description = "about Angular", isActive = false , Instructor=Instructors[1]},
                    new Course() { Name = "React", Price = 20, Description = "about React", isActive = false, Instructor=Instructors[1] },
                    new Course() { Name = "Mvc", Price = 10, Description = "about Mvc", isActive = false, Instructor=Instructors[2] }
                };
                return courses;
            }
        }

        private static Student[] Students
        {
            get
            {
                Student[] students = new Student[]
                {
                    new Student() { Name = "Student 1"},
                    new Student() { Name = "Student 2"},
                    new Student() { Name = "Student 3"},
                    new Student() { Name = "Student 4"}
                };
                return students;
            }
        }

        private static Instructor[] Instructors = {
            new Instructor(){  Name="Ahmet", Contact=new Contact(){  Email="ahmet@gmail.com", Phone="1213132", Address=new Address(){  City="Kocaeli", Country="Türkiye", Text="Atatürk cad.No:45"} } },
            new Instructor(){  Name="Mehmet", Contact=new Contact(){  Email="mehmet@gmail.com", Phone="1213132", Address=new Address(){  City="İstabul", Country="Türkiye", Text="Atatürk cad.No:45"} } },
            new Instructor(){  Name="Ali", Contact=new Contact(){  Email="ali@gmail.com", Phone="1213132", Address=new Address(){  City="Adana", Country="Türkiye", Text="Atatürk cad.No:45"} } },
            new Instructor(){  Name="Hasan"}
        };

        private static User[] Users = {

            new User(){ Username="sadikturan", Email="sadikturan@gmail.com", Password="123456", City="Kocaeli"},
            new User(){ Username="cinarturan", Email="cinarturan@gmail.com", Password="123456", City="Kocaeli"},
            new User(){ Username="emelturan", Email="emelturan@gmail.com", Password="123456", City="İstanbul"},
        };
    }
}
