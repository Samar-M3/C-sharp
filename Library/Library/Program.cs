using System.Net.Security;
using ClassLibrary1;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.Id = 1;
            obj.Name = "jhon the don";
            obj.DisplayInfo();
        }



        public static void AddOne(int number)
        {
            int result = number + 1;
            Console.WriteLine($"Result: {result}");
            if (result == 10)
            {
                return;
            }
            AddOne(result);
        }


        public static void RunRecursion(int level)
        {
            if ( level <= 0)
                return;

            RunRecursion(level - 1);
            Console.WriteLine($"Level: {level}");


        }
    }
}
