using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace somecode.Constructor
{
    internal class Student
    {
        public int Id;
        public string name;

        public Student()
        {
            Id = 0;
            Console.WriteLine("Default Constructor called");
        }
        public Student(int id)
        {
            Id = id;
            Console.WriteLine("Parameterized Constructor called");
        }

    }
}
