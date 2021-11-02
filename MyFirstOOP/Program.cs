using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating real object oop language we called intance
            Person student1 = new Person();
            student1.name = "Abdullokh";
            student1.age = 22;
            student1.Introduce();
            student1.university = "WIUT";
            student1.level = 5;
            student1.abtEdu();
        }
    }
}
