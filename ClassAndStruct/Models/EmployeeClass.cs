using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndStruct.Models
{
    internal class EmployeeClass
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public EmployeeClass() { 
            
        }
        public EmployeeClass(int id, string name)
        {    
            EmployeeId = id;
            EmployeeName = name;
        }

        public virtual string PrintDetails()
        {
            return $"Employee Id: {EmployeeId}\n" +
                $"Employee Name: {EmployeeName}\n";
        }
    }
}
