using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentList.Models;

namespace StudentList.Controllers
{
    
    public class StudentDetailsController : Controller
    {
        public List<StudentForm> students = new List<StudentForm>()
        {
         new StudentForm{Name="Anil",Age=24},
         new StudentForm{Name="Akhil",Age=28},
         new StudentForm{Name="Joy",Age=20},
         new StudentForm{Name="Jessie",Age=22},
         new StudentForm{Name="Priya",Age=24},
         new StudentForm{Name="Vinod",Age=20},
         new StudentForm{Name="Mike",Age=26},
         new StudentForm{Name="Ajay",Age=21},
         new StudentForm{Name="Kamal",Age=23},
         new StudentForm{Name="Sam",Age=25},
        };
        public IActionResult Index()

        {
            var Data = new StudentModel()
            {
              Students=students
             

            };
            return View(Data);
        }
        [HttpPost]
        public IActionResult Index(StudentModel Input)
        {

            var element = students.Where(x => x.Name.Contains(Input.Search)).ToList();
            var Data = new StudentModel()
            {
                Students=element


            };

            return View(Data);

        }
        
    }
}