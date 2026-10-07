using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    internal class Program
    {
        private static void Main(string[] args)
        {
    Program pg=new Program();
            Console.WriteLine(pg.Add(5, 10));
            Console.WriteLine(pg.Add(5, 10, 15));
            Console.WriteLine(pg.Add(5.5f, 10.5f));
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public float Add(float a, float b)
        {
            return a + b;
        }
    }   
}



