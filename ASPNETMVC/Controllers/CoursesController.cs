using CoursesManagement.Domain;
using System.Collections.Generic;
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

        private IList<Course> courses = new List<Course>
        {
            new Course
            {
                Name = "Formacion Amaris",
                Students = students,
                Teacher = teacher
            },
            new Course
            {
                Name = "Formacion Customerville",
                Students = students,
                Teacher = teacher
            },
            new Course
            {
                Name = "Formacion Inventada",
                Students = students,
                Teacher = teacher
            },
        };

        // GET: Courses
        public ActionResult Index()
        {
            return View(courses);
        }
    }
}