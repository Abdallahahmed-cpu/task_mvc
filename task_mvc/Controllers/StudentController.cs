using Microsoft.AspNetCore.Mvc;
using task_mvc.Models;

namespace task_mvc.Controllers
{
    public class StudentController : Controller
    {
        private readonly List<Student> _students = new List<Student>
    {
        new Student { Id = 1, Name = "Alice", Img = "alice.jpg", Address = "123 Main St" },
        new Student { Id = 2, Name = "Bob", Img = "bob.jpg", Address = "456 Elm St" }
    };

        public IActionResult GetAllStudents()
        {
            return View("index", _students); 
        }

        public IActionResult StudentById(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View("index", student); 
        }
    }

}
