using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_StudentIntoOOP
{
    class StudentDetails
    {
        Student me = new Student("Crystal", "Reimche", 3.2f);
        Student you = new Student(9, "Tricia", "Reimche", 3.9f);

        public void displayStudent()
        {
            Console.WriteLine(String.Format("{0} {1} has a GPA of {2:F2}", me.FirstName, me.LastName, me.GPA));
            Console.WriteLine(String.Format("{0} {1}'s student ID is #{2} and has a GPA of {3:F2}", you.FirstName, you.LastName, you.StudentID, you.GPA));
        }
    }
}
