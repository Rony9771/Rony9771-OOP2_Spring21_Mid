using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Main
    {
        public static void Main()
        {
           
            Student s1 = new Student();
            s1.SetId("17-34738-2");
            s1.SetName("Rony");
            s1.SetCgpa(3.76);
            s1.SetDept("CSE");
            s1.ShowStudentInfo();

            Triangle t1 =new Triangle();
            t1.SetX(100);
            t1.SetY(50);
            t1.SetZ(20);
            t1.ShowTriangleInfo();

            Course c1 = new Course();
            c1.SetCourseName("C#");
            c1.SetCourseCode("23r4823");
            c1.SetCourseCredit(3);
            c1.ShowCourseInfo();


            

           
        }
    }
}