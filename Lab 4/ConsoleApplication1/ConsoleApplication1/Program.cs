using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Depertment de1 = new Depertment("Computer science", "CS");
            Depertment de2 = new Depertment("Electrical Eng.", "EEE");
            Student s1 = new Student("Rony Ahmed", "1734", 3.55f);
            Student s2 = new Student("Nabil Hasan", "7382", 2.95f);
            s1.Depertment = de1;
            s2.Depertment = de2;
            s1.show();
            s2.show();


        }
    }
}