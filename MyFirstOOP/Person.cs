using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOOP
{
    class Person
    {
        // we are creating fields for person class
        public string name;
        public int age;
        public string university;
        public int level;

        // creating method
        public void Introduce()
        {
            Console.WriteLine("My name is " + name+"." + "I am  " + age + " years old");
        }

        public void abtEdu()
        {
            Console.WriteLine("My univerity is called" + " " + university + " " + "and my level is " + level);
        }
    }
}
