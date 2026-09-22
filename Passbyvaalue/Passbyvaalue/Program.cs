namespace Passbyvaalue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int n = 10;
            PassByReference_ValueType(n);
            Console.WriteLine("value after method call " + n); // Output: 20
            PassByReference_ValueType(ref n);
            Console.WriteLine("value after method call " + n);
        }
        static void PassByReference_ValueType(int a)
        {
            a = 100;
        }
        static void PassByReference_ValueType(ref int a)
        {
            a = 100;
        }
    }
}



