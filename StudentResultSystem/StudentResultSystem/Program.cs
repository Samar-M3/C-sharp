using System.Xml.Linq;

namespace StudentResultSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students");
            int NumberOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < NumberOfStudents; i++) { 
                Console.WriteLine($"Enter name for student {i+1}");
                string name = Console.ReadLine();
                Console.WriteLine("Enter marks for subject 1");
                float sub1=float.Parse(Console.ReadLine());
                Console.WriteLine("Enter marks for subject 2");
                float sub2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter marks for subject 3");
                float sub3 = float.Parse(Console.ReadLine());

                float total = sub1 + sub2 + sub3;
                float percentage = (total / 300) * 100;

                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Total Marks: {total}");
                Console.WriteLine($"Percentage: {percentage}%");
                if (percentage <= 100 && percentage >= 40)
                {
                    Console.WriteLine("you have passed!!!!!");

                }
                else if (percentage <= 39 && percentage >= 0)
                {
                    Console.WriteLine("you failed!!");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
    }
}
