using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mMTG_Export
{
    public class ExportService
    {
        //Student student = new Student();

                List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "John" },
            new Student { Id = 2, Name = "Doe" }
        };

    }


    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
