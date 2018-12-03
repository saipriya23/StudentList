using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentList.Models
{
    public class StudentModel
    {
        public List<StudentForm> Students { get; set; }
        public string Search { get; set; }
    }
}
