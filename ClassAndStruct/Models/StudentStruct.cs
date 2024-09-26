using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndStruct.Models
{
        public struct StudentStruct
        {
            public int StudentollNo { get; set; }
            public string StudentName { get; set; }

        
            public StudentStruct(int rollNo, string name)
            {
                StudentollNo = rollNo;
                StudentName = name;
            }

            public override string ToString()
            {
                return $"Roll Number of Student : {StudentollNo}\n" +
                    $"Name of Student: {StudentName}\n";
            }
        }
}
