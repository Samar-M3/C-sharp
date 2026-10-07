using System;
using System.Collections.Generic;
using System.Text;

namespace somecode.Protected
{
    internal class Student:Human
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id, string name, int age):base(age)
        {
            this.Id = id;
            this.Name = name;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student ID: {Id}, Name: {Name}, Age: {Age}");
        }
    }
}
