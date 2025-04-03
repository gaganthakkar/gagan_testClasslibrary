using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mMTG_Export
{
    public class ExportServices
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee {Id =  1, Name = "John"},
            new Employee {Id =  2, Name = "Doe"},
        };

    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
