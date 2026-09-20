namespace evenodd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("enter a number");
            int number=int.Parse(Console.ReadLine());
            if (number%2==0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
        }
    }
}
