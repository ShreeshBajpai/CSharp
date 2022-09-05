using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace September_2
{
    public class Student
    {
        public string StudentName = "";
        public static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }
    }
}
