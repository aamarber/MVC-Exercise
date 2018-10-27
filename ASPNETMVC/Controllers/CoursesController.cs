using CoursesManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web.Mvc;

namespace ASPNETMVC.Controllers
{
    public class CoursesController : Controller
    {
        private static IList<Student> students = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "David"
            },
            new Student
            {
                Id = 2,
                Name = "Pablo"
            },
            new Student
            {
                Id = 3,
                Name = "Moisés"
            },
            new Student
            {
                Id = 4,
                Name = "Sergio"
            }
        };

        private static Teacher teacher = new Teacher
        {
            Name = "Aarón",
            Id = 1
        };

        private static decimal[] gradesValues = GetGrades();

        private static decimal[] GetGrades()
        {
            decimal[] gradesValues = new decimal[4];

            for(var i = 0; i < 4; i++)
            {
                Thread.Sleep(10);

                gradesValues[i] = new decimal(new Random().NextDouble() * 10);
            }

            return gradesValues;
        }

        private static IList<Grade> grades = new List<Grade>
        {
            new Grade
            {
                Student = students[0],
                Teacher = teacher,
                Value = gradesValues[0]
            },
            new Grade
            {
                Student = students[1],
                Teacher = teacher,
                Value = gradesValues[1]
            },
            new Grade
            {
                Student = students[2],
                Teacher = teacher,
                Value = gradesValues[2]
            },
            new Grade
            {
                Student = students[3],
                Teacher = teacher,
                Value = gradesValues[3]
            },
        };

        private IList<Course> courses = new List<Course>
        {
            new Course
            {
                Id = 1,
                Name = "Formacion Amaris",
                Students = students,
                Teacher = teacher,
                Grades = grades
            },
            new Course
            {
                Id = 2,
                Name = "Formacion Customerville",
                Students = students,
                Teacher = teacher,
                Grades = grades
            },
            new Course
            {
                Id = 3,
                Name = "Formacion Inventada",
                Students = students,
                Teacher = teacher,
                Grades = grades
            },
        };

        // GET: Courses
        public ActionResult Index()
        {
            return View(courses);
        }

        public ActionResult Detail(int id)
        {
            return View(courses.SingleOrDefault(x => x.Id == id));
        }
    }
}