using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndStruct.Models
{
    internal class ManagerClass:EmployeeClass
    {
        public ManagerClass(int id, string name) : base(id, name) { }

        public override string PrintDetails()
        {
            return base.PrintDetails() +
                $"Employee Designation: Manager\n";
        }
    }
}
